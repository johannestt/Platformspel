using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // en statisk int så att det är samma över alla scripts
    public static int score;

   // sätter värdet av ett myn
    public int amount = 1;

    private float spinSpeed = 180; // en fast snurr fart för coinet

    // private update funktion ( man kan inte ändra den i unity
    private void Update()
    {
        
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0); // Roterar Coine spriten , deltatid * hastigheten , Alltså snurrar myntet på y axeln
    }

    // När något rör myntet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om det som rör är taggad "player"
        if(collision.tag == "Player")
        {
            // Lägger till +1 på den statiska variablen "score" i "coinPickup" scriptet
            Coin.score += amount;
            // tar bort myntet
            Destroy(gameObject);
        }
    }
}
