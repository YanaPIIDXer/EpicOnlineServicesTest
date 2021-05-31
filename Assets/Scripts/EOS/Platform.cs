using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Epic.OnlineServices;
using Epic.OnlineServices.Platform;
using Epic.OnlineServices.Logging;
using System;
using UniRx;
using System.Runtime.InteropServices;

namespace EOS
{
    /// <summary>
    /// プラットフォーム
    /// </summary>
    public class Platform : MonoBehaviour
    {
        /// <summary>
        /// インスタンス
        /// </summary>
        /// <value></value>
        public static Platform Instance { get; private set; } = null;

        /// <summary>
        /// プラットフォームインタフェース
        /// </summary>
        public PlatformInterface Interface { get; private set; } = null;

        /// <summary>
        /// 初期化完了Subject
        /// </summary>
        private Subject<Unit> OnInitializeSubject = new Subject<Unit>();

        /// <summary>
        /// 初期化が完了した
        /// </summary>
        public IObservable<Unit> OnInitialize { get { return OnInitializeSubject; } }
#if UNITY_EDITOR
        [DllImport("Kernel32.dll")]
        private static extern IntPtr LoadLibrary(string lpLibFileName);

        [DllImport("Kernel32.dll")]
        private static extern int FreeLibrary(IntPtr hLibModule);

        [DllImport("Kernel32.dll")]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        private IntPtr LibraryPointer;
#endif
        void Awake()
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

#if UNITY_EDITOR
            var LibPath = $"Assets/EOSSDK/EOSSDK-Win64-Shipping.dll";

            LibraryPointer = LoadLibrary(LibPath);
            if (LibraryPointer == IntPtr.Zero)
            {
                throw new Exception($"Failed to load library {LibPath}");
            }

            Bindings.Hook(LibraryPointer, GetProcAddress);
#endif

            var InitOption = new InitializeOptions()
            {
                ProductName = "EpicOnlineServicesTest",
                ProductVersion = "1.0.0"
            };

            var InitResult = PlatformInterface.Initialize(InitOption);
            if (InitResult != Epic.OnlineServices.Result.Success && InitResult != Epic.OnlineServices.Result.AlreadyConfigured)
            {
                throw new Exception("Platform Initialize Failed. Reason:" + InitResult.ToString());
            }

            var Credentials = new ClientCredentials();
            Credentials.ClientId = Environments.Environments.Instance.ClientId;
            Credentials.ClientSecret = Environments.Environments.Instance.ClientSecret;

            var Opt = new Options();
            Opt.ClientCredentials = Credentials;
            Opt.ProductId = Environments.Environments.Instance.ProductId;
            Opt.SandboxId = Environments.Environments.Instance.SandboxId;
            Opt.DeploymentId = Environments.Environments.Instance.DeploymentId;

            Interface = PlatformInterface.Create(Opt);
            if (Interface == null)
            {
                throw new Exception("Platform Interface Create Failed.");
            }

            LoggingInterface.SetLogLevel(LogCategory.AllCategories, LogLevel.VeryVerbose);
            LoggingInterface.SetCallback((Msg) => Debug.Log(Msg));

            OnInitializeSubject.OnNext(Unit.Default);
            OnInitializeSubject.OnCompleted();
        }

        void OnDestroy()
        {
            if (Interface != null)
            {
                Interface.Release();
                PlatformInterface.Shutdown();
                Interface = null;
            }

#if UNITY_EDITOR
            if (LibraryPointer != IntPtr.Zero)
            {
                // Free until the module ref count is 0
                while (FreeLibrary(LibraryPointer) != 0) { }
                LibraryPointer = IntPtr.Zero;

                Bindings.Unhook();
            }
#endif
        }

        void Update()
        {
            Interface.Tick();
        }
    }
}
