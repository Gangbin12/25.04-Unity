using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Text[] textlist;
    [SerializeField] string[] titleList;

    private void Start()
    {
        for(int i = 0; i < textlist.Length; i++)
        {
            textlist[i].text = titleList[i];
        }
    }

    public void Execute()
    {
        Debug.Log("Execute");
    }

    public void Shop()
    {
        Debug.Log("Shop");

    }

    public void Quit()
    {
        Debug.Log("Quit");
    }
}
