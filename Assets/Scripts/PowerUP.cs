using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
    // statisk variabel den e samma över alla skripts
    public static int PowerLevel;
    public PlayerMovement Movement;
   

    // Use this for initialization
    void Start()
    {

    }
    // Om man går in i ett object med detta script på som har trigger så händer det under
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // händer bara object med taggen Player
        if (collision.tag == "Player")
        {
            // Man får Powerlevel 1
            PowerLevel += 1;

            // Powerlevel 1 ger dig i detta fall movespeed +1 och jumpspeed+4
            if (PowerLevel == 1)
            {
                PlayerMovement.moveSpeed += 1f;

                PlayerMovement.jumpSpeed += 4f;
            }
            // Förstör objectet efter så man bara får en powerlevel
            Destroy(gameObject);

 
        }
        
 
        
    }

}
