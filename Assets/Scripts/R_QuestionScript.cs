using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ラジアンから変換する問題
/// 問題セットから分母をとってきて、マネージャーに代入
/// その後、分母をもとに分子を代入
/// </summary>
public class R_QuestionScript : MonoBehaviour
{
    [SerializeField] RD_ManagerScript RD_;
    [SerializeField] R_SetsScript R_;
    int[] QestionsSets;

    void refleshSet() { QestionsSets = null; }
    public void setQ1() { QestionsSets = R_.first; }
    //一番最初のステージ(まずは)
    public void stage1()
    {
        int tmp = Random.Range(1,4);
        RD_.denominator = QestionsSets[tmp];
        RD_.numerator=R_.CalcNumerator(tmp,1);
        RD_.setDeg();
    }
}
