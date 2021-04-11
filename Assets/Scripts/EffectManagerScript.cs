using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectManagerScript : MonoBehaviour
{
    [SerializeField] GameObject EffectPanel;
    [SerializeField] int MaxAlpha;
    Color Panelcolor;
    float R, G, B;
    Image image;

    [SerializeField] int flashSpeed;
    bool canFlash = false;
    int panel_a;

    private void Start()
    {
        Panelcolor = EffectPanel.GetComponent<Image>().color;
        R = Panelcolor.r;
        G = Panelcolor.g;
        B = Panelcolor.b;
        image = EffectPanel.GetComponent<Image>();
        //image.color=new Color(255,255,255,255);
        //setPanelAlpha(128);
        //EffectPanel.GetComponent<Renderer>().color.a = 255;
    }

    public void onFlashPanel()
    {
        canFlash = true;
        panel_a = 0;
        Panelcolor = EffectPanel.GetComponent<Image>().color;
        
        //Debug.Log("フラッシュ！"); 
        
    }
    private void Update()
    {
        if (canFlash)
        {
            panel_a += flashSpeed;
            setPanelAlpha(calcAlpha(panel_a));
            if (panel_a > 2*MaxAlpha-2) canFlash = false;

        }
    }
    int calcAlpha(int alpha)
    {
        return (alpha < MaxAlpha) ? alpha : (2*MaxAlpha-2) - alpha;
    }
    void setPanelAlpha(int a)
    {
        //Debug.Log("アルファをセット:"+a);
        image.color = new Color(R, G, B, 1.0f*a/256) ;
    }
}
