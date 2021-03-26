using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 選択しのデータを保持するだけ
/// オブジェクトを参照し、
/// これのデータを読みとる
/// </summary>
public class R_ChoiceDate : MonoBehaviour
{
    [SerializeField] int denominator;
    [SerializeField] int numerator;//これでゲッターになる？


    public R_ChoiceDate OnChoice()
    {
        return this;
    }

    //ゲッター
    public int getDen() { return denominator; }
    public int getNum() { return numerator; }
}
