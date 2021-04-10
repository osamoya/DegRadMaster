using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel_Script : MonoBehaviour
{
    [SerializeField] GameObject MainPanel;
    [SerializeField] GameObject ResultPanel;

    enum PanelMode
    {
        MAIN,
        RESULT,
    };

    public void dispMainPanel()
    {
        movePanel(MainPanel, 0);
        movePanel(ResultPanel, -1080);
    }

    public void dispResultPanel()
    {
        movePanel(ResultPanel, 0);
        movePanel(MainPanel, 1080);
    }

    private  void movePanel(GameObject panel,int x)
    {
        panel.gameObject.transform.localPosition=new Vector3(x,0,0);
    }
}
