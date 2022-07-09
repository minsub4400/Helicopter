using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingRotation : MonoBehaviour
{
    public GameObject gameOB;
    public float rotationSpeedY;
    void Start()
    {
        rotationSpeedY = 0;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            gameOB.transform.Rotate(0, rotationSpeedY++, 0);
        }
        else
        {
            if (rotationSpeedY > 0)
            {
                gameOB.transform.Rotate(0, rotationSpeedY--, 0);
            }
        }
    }


}
