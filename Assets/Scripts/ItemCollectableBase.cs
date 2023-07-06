using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableBase : MonoBehaviour
{

    public int Coins;

    protected virtual void Collect()
    {
        Debug.Log("Coin Collect");
        gameObject.SetActive(false);
        Coins++;
        Collected();
    }
    protected virtual void Collected() { }

    public string comparetag = "Player";


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(comparetag))
        {
            Collect();

        }

           
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Coins = 0;
    }
}
