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
    public ChangePanel_Script ChangePanel_;
    public ResultText_Script ResultTezt_;
    public ArrowMove_Script ArrowMove_;
    public EffectManagerScript effectManager_;
    public Text Source;
    public int Qnumber { get; private set; }
    public int CorrectNum { get; private set; }
    private float ElapsedTime;
    private State state;
    enum State
    {
        MAIN,
        RESULT,
    };
    // Start is called before the first frame update
    void Start()
    {
        ChangePanel_.dispMainPanel();
        state=State.MAIN;
        Qnumber = 0;
        ElapsedTime = 0;
        retry();
        ArrowMove_.setArrows();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.MAIN:
                mainState();
                break;
            case State.RESULT:
                break;
        }
        
    }

    public void mainState()
    {
        ElapsedTime += Time.deltaTime;
        if (Qnumber == MaxQuestion)
        {
            state = State.RESULT;
            ChangePanel_.dispResultPanel();
            ResultTezt_.changeResult((int)ElapsedTime,CorrectNum);
            ArrowMove_.hideArrows();
        }
    }
    public void resultState()
    {

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
        Debug.Log("今の時間："+ElapsedTime);
        Debug.Log("回答。今" + Qnumber + "問目");
        effectManager_.onFlashPanel();
    }
    public void addScore()
    {
        if (CorrectNum < MaxQuestion) CorrectNum++;
    }
}
