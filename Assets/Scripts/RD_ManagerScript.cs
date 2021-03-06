using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RD_ManagerScript : MonoBehaviour
{
    public int inputDen;//入力分母
    public int inputNum;//入力分子
    public int denominator;//分母
    public int numerator;//分子
    public int deg;//度数法

    public GameManagerScript gameManagerScript_;

    bool checkAns()
    {
        if (inputDen != denominator) return false;
        if (inputNum != numerator) return false;
        return true;
    }

    public void setDeg()
    {
        deg = 180 * numerator / denominator;
    }

    void convertDeg(int inputdeg)
    {
        int root = (180 % inputdeg == 0) ? inputdeg : 180 % inputdeg;
        denominator = 180 / root;
        numerator = inputdeg / root;
    }

    public void OnClickChoice()
    {
        Debug.Log("結果："+checkAns());
        if (checkAns()) gameManagerScript_.addScore();
        gameManagerScript_.retry();
    }
}
