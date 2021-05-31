using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;
using System;
using Epic.OnlineServices.Auth;
using EOS;

/// <summary>
/// 実験用のボタン
/// 用が済んだら消す
/// </summary>
public class TestButton : MonoBehaviour
{
    void Awake()
    {
        GetComponent<Button>().OnClickAsObservable()
            .Subscribe(_ =>
            {
                var Opt = new LoginOptions()
                {
                    Credentials = new Credentials()
                    {
                        Type = LoginCredentialType.AccountPortal
                    }
                };

                Platform.Instance.Interface.GetAuthInterface().Login(Opt, null, (Info) =>
                {
                    Debug.Log("LogInResult:" + Info.ResultCode.ToString());
                });
            })
            .AddTo(gameObject);
    }
}
