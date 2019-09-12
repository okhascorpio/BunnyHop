using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class food : MonoBehaviour
{
    private Animator anim;
    //private healthbar healthbar;
    void Start()
    {
        anim = GameObject.FindWithTag("Player").GetComponent<Animator>();

    }

    void OnTriggerEnter2D(Collider2D col)
    {
       // if (col.gameObject.tag == "Player")
        {
            AudioScript.PlaySound("eat");
            FindObjectOfType<healthbar>().fullLife=true;
            //fullLife = true;
            //percent=1.0f;
            anim.SetTrigger("food");
            Destroy(this.gameObject);

            //Debug.Log(fullLife);
        }

    }

}
