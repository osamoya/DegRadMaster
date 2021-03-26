using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ラジアンのための分母がいくつか入っている
/// 分子はまだ考えない
/// </summary>
public class R_SetsScript : MonoBehaviour
{
    //まずは分母
    public int[] first = { 2,3,4,6};//基本この人たち
    public int[] second = {12};//応用の時にはこれも


    //分母と象限から、適切な分子を返却する。
    //ただし、第1象限とは0<=θ<=90とする
    //                    分母　　象限
    public int CalcNumerator(int den,int Quadrant)
    {
        if (Quadrant < 1 || Quadrant > 4) { Debug.Log("象限の設定ミス"); return -1; }
        
        //TODO:分母12には対応していません！
        switch (Quadrant)
        {
            case 1:return 1;
            case 2:
                if (den == 2) return 1;
                return den - 1;
            case 3:
                return den + 1;
            case 4:
                if (den == 2) return 2;
                return den * 2 - 1;
        }
        return 0;
    }

}
