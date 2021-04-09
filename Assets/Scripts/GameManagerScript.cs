using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//デスクトップから、更新できるかのテスト

public class GameManagerScript : MonoBehaviour
{
    [SerializeField] int MaxQuestion = 5;
    public RD_ManagerScript RD_;
    public R_QuestionScript R_Q_;
    public Text Source;
    private int Qnumber;
    private float ElapsedTime;
    private float AnsTime;
    // Start is called before the first frame update
    void Start()
    {
        Qnumber = 0;
        ElapsedTime = 0;
        retry();
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime+=Time.deltaTime;
        if (Qnumber == MaxQuestion)
        {
            
        }
    }

    public void retry()
    {
        R_Q_.setQ1();
        R_Q_.stage1();
        Debug.Log("分母："+RD_.denominator+"に設定");
        Source.text = "" + RD_.deg;
        
    }
    
    public void onClickChoice()
    {
        Qnumber++;
        Debug.Log("回答。今" + Qnumber + "問目");

    }
}
