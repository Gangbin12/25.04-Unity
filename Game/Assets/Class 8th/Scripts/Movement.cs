using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    void Start()
    { 


        Debug.Log(transform.position);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3();
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3();
        }
    }
}
