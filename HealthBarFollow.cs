using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarFollow : MonoBehaviour
{
    private Transform player;
    private float healthbarDistance=0.7f;
    private float healthbarHeight=3f;
    // Start is called before the first frame update
    void Awake()
    {
       player=GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GameObject.FindWithTag("Player")){
        transform.position=new Vector2((player.position.x-healthbarDistance),(player.position.y+healthbarHeight));
    }
    }
}
