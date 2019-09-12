using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyFollow : MonoBehaviour
{
    private Transform target;
    private float skyFactor = 0.67f;

    private Vector3 pos;






    void Start()
    {
        target = GameObject.FindWithTag("camera").transform;
    }



    void FixedUpdate()
    {

        pos = new Vector3((target.position.x+0.5f) * skyFactor,6, 0);
        transform.position = pos;

    }

}
