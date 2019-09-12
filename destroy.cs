using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

    bool isActive = false;


    void OnTriggerEnter2D(Collider2D col)
    {

        if (!isActive)
        {
            isActive = true;
            
            if (col.gameObject.tag == "Player")
            {
                Debug.Log("Death by Plant");
                FindObjectOfType<gameManager>().DeathScene();

            }

        }

    }


}
