using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionUpDown : MonoBehaviour
{
    public Rigidbody myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            myRigidbody.velocity = new Vector3(0, +1, 0);
        }
        else
        {
            if (gameObject.transform.position.y > 0)
            {
                myRigidbody.velocity = new Vector3(0, -1, 0);
            }
        }
       
   
    }
}
