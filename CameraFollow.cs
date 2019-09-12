using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public Transform player;
    private Transform target;
    public float rightBound;
    public float leftBound;
    public float topBound;
    public float bottomBound;
    private Vector3 pos;
    private float cameraDistance = -6.0f;
    public float cameraHeight = 0f;
    // Start is called before the first frame update
    void Start()
    {
       if(GameObject.FindWithTag("Player")){
        target = GameObject.FindWithTag("Player").transform;
        
        pos= new Vector3(6.15f,4.74f,cameraDistance);
       }
    }
    void FixedUpdate(){

        
     if(pos.x < rightBound || pos.x > leftBound || pos.y < topBound || pos.y > bottomBound)
     {
         if(GameObject.FindWithTag("Player")){
         
         pos =new Vector3(target.position.x,  (target.position.y), cameraDistance);
         transform.position = pos;
         }
     }
     //Right
     if(pos.x >= rightBound)
     {
         pos.x = rightBound;    
         transform.position = pos;        
     }
     //Left
     if(pos.x <= leftBound)
     {
         pos.x = leftBound;
         transform.position = pos;
     }
     //Top
     if(pos.y >= topBound)
     {
         pos.y = topBound;
         transform.position = pos;
     }
     //Bottom
     if(pos.y <= bottomBound)
     {
         pos.y = bottomBound;
         transform.position = pos;
     }
    }

    // Update is called once per frame
    /*void FixedUpdate()
    {
       // transform.position = new Vector3(target.position.x, (target.position.y + cameraHeight), cameraDistance);
    }*/
}
