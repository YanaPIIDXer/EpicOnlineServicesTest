using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EOS;
using UnityEngine.SceneManagement;
using System;
using UniRx;

namespace Sequence
{
    /// <summary>
    /// 初期化シーケンス
    /// </summary>
    public class InitializeSequence : MonoBehaviour
    {
        void Awake()
        {
            Platform.Instance.OnInitialize
                    .Subscribe(_ =>
                    {
                        SceneManager.LoadScene("Title");
                    })
                    .AddTo(gameObject);
        }
    }
}
