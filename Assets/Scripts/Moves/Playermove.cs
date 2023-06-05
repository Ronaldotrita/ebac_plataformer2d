using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public KeyCode right;
    public KeyCode left;
    public KeyCode jump;
    public Rigidbody2D playerrigid;

    public float speed;
    public Vector2 mov;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))
            //playerrigid.MovePosition(playerrigid.position + mov * Time.deltaTime);
            playerrigid.velocity = new Vector2(speed, playerrigid.velocity.y);
        else if (Input.GetKey(left))
            //playerrigid.MovePosition(playerrigid.position - mov * Time.deltaTime); ;
            playerrigid.velocity = new Vector2(-speed, playerrigid.velocity.y);

    }
}
