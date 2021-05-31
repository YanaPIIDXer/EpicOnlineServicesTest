using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;
using System;

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
            })
            .AddTo(gameObject);
    }
}
