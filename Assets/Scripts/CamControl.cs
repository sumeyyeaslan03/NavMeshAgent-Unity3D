using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
	void Update ()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        transform.position += (Vector3.up * ver + Vector3.right * hor) *Time.deltaTime;
    }

    
}
