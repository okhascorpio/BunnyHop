using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthbar : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0.0f, 1.0f)]

    private static float percent = 1.0f;
    public bool fullLife;
    private Transform bar;
    private static Animator anim;
    private void Start()
    {
        fullLife = false;
        percent = 1.0f;
        bar = GameObject.FindWithTag("Bar").transform;
        anim = GameObject.FindWithTag("Player").GetComponent<Animator>();

        InvokeRepeating("HealthFunction", 0, 1f);

    }



    // Update is called once per frame
    private void HealthFunction()
    {
        // Debug.Log(percent);
        if (percent > 0.016)
        {
            Time.timeScale = 1.0f;
            if (fullLife)
            {
                percent = IncreaseHealth();
                Debug.Log("increase");


            }
            else
            {

                percent = DecreaseHealth(percent);

            }

            bar.transform.localScale = new Vector2(percent, 1f);
            //Debug.Log(fullLife);
        }


        if (percent <= 0.016)
        {
            bar.transform.localScale = new Vector2(0.0f, 1f);
            FindObjectOfType<gameManager>().EndGame();
            // Debug.Log("Die");
            // destroy.DeathScene();
            //Time.timeScale = 0.0f;
            //return;
        }
        fullLife = false;
    }

    private static float DecreaseHealth(float inpuValue)
    {
        float value = (inpuValue - 0.016f);
        return value;
    }

    private static float IncreaseHealth()
    {
        float value = 1.0f;
        return value;
    }


    void Die()
    {

        AudioScript.PlaySound("die");
        movement.gameover = true;
        anim.SetTrigger("death");
        Destroy(GameObject.FindGameObjectWithTag("Player"));


    }



}
