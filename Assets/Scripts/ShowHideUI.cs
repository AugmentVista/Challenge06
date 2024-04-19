using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideUI : MonoBehaviour
{

    public GameObject bear1;
    public GameObject bear2;
    public GameObject bear3;
    bool showing = true;


    public void ShowHiddenUI()
    {
        showing = !showing;
        if (showing)
        { 
            bear1.SetActive(true);
            bear2.SetActive(true);
            bear3.SetActive(true);
        }
        else if (!showing)
        {
            bear1.SetActive(false);
            bear2.SetActive(false);
            bear3.SetActive(false);
        }
    }

}
