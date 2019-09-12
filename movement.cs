using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D Bunny;
    private SpriteRenderer bunnySprite;
    private float speedFactor = 5.0f;
    private bool isMoving;
    private float jumpFactor = 10.0f;

    //Ground Check
    public bool isGrounded;
    public float checkRadius;
    public LayerMask whatIsGround;
    public Transform feetPos
;
    private bool isHopping;
    private bool isJumping;

    private Animator anim;
    public static bool gameover;



    void Start()
    {
        Bunny = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
        //Bunny = GetComponent<Rigidbody2D>();
        anim = GameObject.FindWithTag("Player").GetComponent<Animator>();
        bunnySprite = GameObject.FindWithTag("Player").GetComponent<SpriteRenderer>();
        isGrounded = false;
        anim.SetBool("isJumping", false);
        anim.SetBool("isHopping", false);
        gameover = false;
        //AudioScript.PlaySound("hop");
    }

   /* void update()

    {
        if (Time.timeScale == 0) return;
    }*/


    // Update is called once per frame
    void FixedUpdate()
    {
        if (feetPos.position.y < 0.0f)
        {
            FindObjectOfType<gameManager>().DeathScene();
           // gameover = true;
        }

      /*  if (gameover)
        {
            
            
            //AudioScript.PlaySound("lose");
           // Destroy(GameObject.FindGameObjectWithTag("Player"));
           // Time.timeScale = 0.0f;
           // return;
        }
        else
        {
            Time.timeScale = 1.0f;
            //AudioScript.PlaySound("hop");
        }*/

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        float move = Input.GetAxis("Horizontal") * speedFactor;
        bool jump = Input.GetButtonDown("Jump");
        /*/if (move==0.0f){
            anim.SetBool("isHopping",false);        
            }else anim.SetBool("isHopping",true);
        */
        if (move < 0.0f)
        {
            bunnySprite.flipX = true;
        }
        else
        {
            bunnySprite.flipX = false;
        };


        Vector2 vel = Bunny.velocity;
        vel.x = move;
        Bunny.velocity = vel;
        //anim.SetFloat("hophop", move);
        if (!jump) anim.SetBool("isHopping", true);

        if (move == 0)
        {
            anim.SetBool("isHopping", false);

        }

        if (jump)
        {
            //anim.SetBool("isHopping", false);
            anim.SetBool("isJumping", true);
            if (isGrounded == true)
            {
                //Debug.Log("jump");
                AudioScript.PlaySound("jump");
                Bunny.velocity = Vector2.up * jumpFactor;
                anim.SetFloat("jumpjump", Bunny.velocity.y);
            }
            new WaitForSeconds(1f);

        }
        else anim.SetBool("isJumping", false);

        //anim.SetFloat("jumpjump", Mathf.Abs(Bunny.velocity.y));
    }


}
