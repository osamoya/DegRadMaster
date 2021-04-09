using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//デスクトップから、更新できるかのテスト

public class GameManagerScript : MonoBehaviour
{
    public RD_ManagerScript RD_;
    public R_QuestionScript R_Q_;
    public Text Source;
    private int Qnumber;
    private float ElapsedTime;
    private float AnsTime;
    // Start is called before the first frame update
    void Start()
    {
        retry();
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime+=Time.deltaTime;
    }

    public void retry()
    {
        R_Q_.setQ1();
        R_Q_.stage1();
        Debug.Log("分母："+RD_.denominator+"に設定");
        Source.text = "" + RD_.deg;
        Qnumber = 0;
        ElapsedTime = 0;
    }
    
    public void onClickChoice()
    {
        Qnumber++;

    }
}
