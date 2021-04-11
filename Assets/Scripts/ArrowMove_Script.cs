using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove_Script : MonoBehaviour
{
    [SerializeField] GameObject arrowLeft;
    [SerializeField] GameObject arrowCenter;
    [SerializeField] GameObject arrowRight;
    [SerializeField] GameObject Arrows;

    public void setArrows()
    {
        Arrows.transform.position = new Vector3(0, -1, 0);
    }
    public void hideArrows()
    {
        Arrows.transform.position = new Vector3(0, -100, 0);
    }

}
