using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeCheck : MonoBehaviour
{
    // Start is called before the first frame update


    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            Debug.Log("win");
            AudioScript.PlaySound("win");
            FindObjectOfType<gameManager>().EndGame();
            //movement.gameover = true;

        }
    }
}
