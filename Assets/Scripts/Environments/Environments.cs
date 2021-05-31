using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Environments
{
    /// <summary>
    /// 環境変数
    /// 実際の値はEnvironmentsDefine.csに定義するコンストラクタで放り込まれる
    /// </summary>
    public partial class Environments
    {
        /// <summary>
        /// 製品ＩＤ
        /// </summary>
        public string ProductId { get; private set; } = "";

        /// <summary>
        /// クライアントＩＤ
        /// </summary>
        public string ClientId { get; private set; } = "";

        /// <summary>
        /// クライアントシークレット
        /// </summary>
        public string ClientSecret { get; private set; } = "";

        /// <summary>
        /// アプリケーションＩＤ
        /// </summary>
        public string ApplicationId { get; private set; } = "";

        /// <summary>
        /// サンドボックスＩＤ
        /// </summary>
        public string SandboxId { get; private set; } = "";

        /// <summary>
        /// デプロイメントＩＤ
        /// </summary>
        public string DeploymentId { get; private set; } = "";

        #region Singleton
        public static Environments Instance { get { return _Instance; } }
        private static Environments _Instance = new Environments();
        #endregion
    }
}
