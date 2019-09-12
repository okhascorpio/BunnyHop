using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private static Animator anim;
    bool GameHasEnded = false;
    float restartDelay = 3.0f;
    bool isActive=false;
    void Start()
    {

        anim = GameObject.FindWithTag("Player").GetComponent<Animator>();

    }
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            //Debug.Log("Game Over");
            Invoke("Restart", restartDelay);

        }

    }

    void Restart()
    {
        //Destroy(GameObject.FindGameObjectWithTag("Player"));
        //Destroy(GameObject.FindGameObjectWithTag("Health"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("restart");
    }

    public void DeathScene()
    {
        if (!isActive)
        {
            isActive = true;
            AudioScript.PlaySound("lose");
            anim.SetTrigger("death");
            movement.gameover=true;
            //Time.timeScale = 0.0f;
            EndGame();
            //Invoke("Die", 1f);
            //new WaitForSeconds (2);
            //Destroy(GameObject.FindGameObjectWithTag("Player"));
        }
    }

   /*  public void Die()
    {
        movement.gameover = true;
        // Destroy(GameObject.FindGameObjectWithTag("Player"));
        
    }*/


}
