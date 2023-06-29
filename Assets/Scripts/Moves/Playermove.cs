using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    [Header("BOTOES")]

    public KeyCode right;
    public KeyCode left;
    public KeyCode jump;
    public KeyCode run;

    [Header("VETOR")]
    public Rigidbody2D playerrigid;

    [Header("VELOCIDADE")]
    public Vector2 speed;
    public Vector2 desacelaration;

    [Header("ANIMATION")]

    public Animator jumpanimation;
    public Animator runanimation;



    // Start is called before the first frame update

    private void Awake()
    {
        jumpanimation.SetBool("Jump", false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moviment();
        Jumpmov();
        breakmove();
        running();
        

    }

    private void Moviment()
    {

        if (Input.GetKey(right))
        {
            //playerrigid.MovePosition(playerrigid.position + mov * Time.deltaTime);
            playerrigid.velocity = new Vector2(speed.x, playerrigid.velocity.y);
            runanimation.SetBool("Run", true);
            playerrigid.transform.localScale = new Vector3(1, 1, 1);

        }
        else if (Input.GetKey(left))
        { 
            //playerrigid.MovePosition(playerrigid.position - mov * Time.deltaTime); ;
            playerrigid.velocity = new Vector2(-speed.x, playerrigid.velocity.y);
            runanimation.SetBool("Run", true);
            playerrigid.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
            runanimation.SetBool("Run", false);
    }

    private void Jumpmov()
    {
        if (Input.GetKeyDown(jump))
        {

            playerrigid.velocity = new Vector2(playerrigid.velocity.x, speed.y);
            jumpanimation.SetBool("Jump", true);
        }

        


    }


    private void breakmove()
    {
        if (playerrigid.velocity.x > 0)
            playerrigid.velocity = new Vector2((playerrigid.velocity.x - desacelaration.x), playerrigid.velocity.y);

        else if(playerrigid.velocity.x < 0)
            playerrigid.velocity = new Vector2((playerrigid.velocity.x + desacelaration.x), playerrigid.velocity.y);

           
    }

    private void running()
    {
        if (Input.GetKey(run))
           playerrigid.velocity = new Vector2((playerrigid.velocity.x * 2), playerrigid.velocity.y);
        runanimation.speed = 2;
           
           
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            jumpanimation.SetBool("Jump", false);
        }
    }


}
