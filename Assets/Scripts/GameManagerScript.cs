using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public RD_ManagerScript RD_;
    public R_QuestionScript R_Q_;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retry()
    {
        R_Q_.setQ1();
        R_Q_.stage1();
        Debug.Log("分母："+RD_.denominator+"に設定");
    }
}
