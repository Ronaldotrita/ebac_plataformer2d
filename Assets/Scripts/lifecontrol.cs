using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifecontrol : MonoBehaviour
{
    public int Life;
    private int Currentlife;
    public bool Destroyonkill = false;
    private bool isdead = false;
    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Takedamage(int damage)
    {
        Currentlife = Life - damage;
        if (Currentlife <= 0)
            Kill();
    }

    private void Kill()
    {
        isdead = true;
        if(Destroyonkill)
        Destroy(Player);
    }

    
}
