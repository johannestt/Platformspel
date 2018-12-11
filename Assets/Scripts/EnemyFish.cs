using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFish : MonoBehaviour
{
    // gör ett nummer med decimaler speed
    public float speed = 1f;
    // gör sant eller falskt till left
    public bool left = true;

    // Skapar en Rigidbody
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        // hämtar rigidbody till enemy
        rbody = GetComponent<Rigidbody2D>();
    }
    //   Det är som update men gånger deltatime frames i private kan man bara ändra det i unity
    private void FixedUpdate()
    {
        if (left == true)
        {
            // Sätter hastigheten på enemy till Vänster (Vector2) koverterar från en Vector3
            rbody.velocity = -(Vector2)transform.right * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            // Sätter hastigheten på enemy till höger (Vector2) koverterar från en Vector3
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    // Gör så att det händer något när man går in i ett objekt ( Bara 2D)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kollar om det händer en kollison med nåt med taggen "InvisibleWall"
        if (collision.tag == "InvisibleWall")
        {
            // vänder om det ovan kolliderar med invisiblewall
            left = !left;

        }  

           // Kollar om det händer en kollision med något med taggen "Player"
            if (collision.tag == "Player")
            {
            // Ger "Player" -10movespeed Som också inverterar kontrollerna så man sedan går vänster  när man trycker på "D" och höger på "A" istället för att man går höger på "D" och vänster på "A"
                PlayerMovement.moveSpeed -= 10;

                Destroy(gameObject);
            }
    }
}
