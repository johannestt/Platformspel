using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBee : MonoBehaviour
{
    // gör ett nummer med decimaler speed
    public float speed = 1f;
    // gör sant eller falskt till left
    public bool left = true;
    // laddar sample scene som är min första bana i detta fall så får man börja om man blir träffad av Biet
    public string sceneToLoad = "SampleScene";
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

        // Kollar om det händer en kollision
        if (collision.tag == "Player")
        {
            // Laddar scenen som jag i variablen sceneToLoad
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
