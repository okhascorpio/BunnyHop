using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudFollow : MonoBehaviour
{
    private Transform target;
    
    private float skyFactor = 0.5f;
    private Vector3 pos;

    void Start()
    {
        target = GameObject.FindWithTag("camera").transform;
    }




    void FixedUpdate()
    {

        // 


        pos = new Vector3((target.position.x) * skyFactor, 7, 0);
        transform.position = pos;

    }

}
