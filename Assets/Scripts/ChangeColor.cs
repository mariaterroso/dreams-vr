using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color targetColorEnter;
    public Color targetColorExit;
    public Color targetColorClick;

    public void ChangeColorEnter()
    {
        GetComponent<Renderer>().material.color = targetColorEnter;
    }

    public void ChangeColorExit()
    {
        GetComponent<Renderer>().material.color = targetColorExit;
    }

    public void ChangeColorClick()
    {
        GetComponent<Renderer>().material.color = targetColorClick;
    }

}
