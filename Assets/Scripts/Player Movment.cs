using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float playerSpeed = 6;
    public float horizontalSpeed = 3;
    public float Rightlimit = 5.5f;
    public float Leftlimit = -5.5f;


    void Update()
    {


        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > Leftlimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
                if (this.gameObject.transform.position.x < Rightlimit)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
                }
            
        }
    }
}


