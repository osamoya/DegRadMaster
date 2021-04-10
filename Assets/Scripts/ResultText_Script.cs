using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// リザルトの文章を変更するためのスクリプト
/// 変更する項目は、タイム・正答数・ランク・一言
/// </summary>
public class ResultText_Script : MonoBehaviour
{
    public GameManagerScript GMS_;

    [SerializeField] Text time_t;
    [SerializeField] Text correct_t;
    [SerializeField] Text rank_t;
    [SerializeField] Text comment_t;

    private enum RANK{
        NOOB,//2割りとか
        NORMAL,//5
        PRO,//8
        MASTER,//10
    };
    
    

    public void changeResult(int time,int correct)
    {
        int allQ = GMS_.Qnumber;
        RANK rank = calcRank(allQ,correct);

        time_t.text = time + "s";
        correct_t.text = correct+"/"+allQ;
        rank_t.text = rank.ToString();
        comment_t.text = RankComment[(int)rank];
        
    }

    private RANK calcRank(int All,int correct)
    {
        if (correct == All) return RANK.MASTER;
        float percent = 1.0f * correct / All;
        Debug.Log("正答率の計算をします。正答率は："+percent);
        if (percent>= 0.8) return RANK.PRO;
        if (percent >= 0.5) return RANK.NORMAL;
        return RANK.NOOB;
    }

    private string[] RankComment=new string[]
    {
        "まずはゆっくりで良いから正解できるように。反射で答えるのはまた後で。",
        "最初は数字と位置を関連させて記憶しても大丈夫！慣れるまでファイト！",
        "悪くない。もう少しでパーフェクト！押し間違えに気を付けつつ頑張ろう。",
        "さすが。位置で覚えているかもしれないが、それも一つの暗記の仕方。頑張ったね！",
    };

}
