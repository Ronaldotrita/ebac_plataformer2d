using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public KeyCode right;
    public KeyCode left;
    public KeyCode jump;
    public KeyCode run;
    public Rigidbody2D playerrigid;

    public Vector2 speed;
    public Vector2 desacelaration;
    
    

    // Start is called before the first frame update
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
            //playerrigid.MovePosition(playerrigid.position + mov * Time.deltaTime);
            playerrigid.velocity = new Vector2(speed.x, playerrigid.velocity.y);
        else if (Input.GetKey(left))
            //playerrigid.MovePosition(playerrigid.position - mov * Time.deltaTime); ;
            playerrigid.velocity = new Vector2(-speed.x, playerrigid.velocity.y);
    }
    
    private void Jumpmov()
    {
        if (Input.GetKeyDown(jump))
            playerrigid.velocity = new Vector2(playerrigid.velocity.x, speed.y);
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
           
    }
    
}
