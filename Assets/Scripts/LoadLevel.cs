using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    // Gör en int som heter MinimumScoreNeeded
    public int minimumScoreNeeded = 0;
    // Gör en string med namn på en scen som unity ska ladda. (Kan bero på vad man vill skriva här så att man kan ladda flera olika scener)
    public string sceneToLoad = "SampleScene";
     // När Man rör vid en trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Om spelaren har t.ex 10 eller 100coins så kan han laddas in i en ny bana.
        if (collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            // Gör så att coin score börjar som 0
            Coin.score = 0;
            // Gör så att power level börjar som noll och resetas till noll efter man dör
            PowerUP.PowerLevel = 0;
            // Gör så att de laddar sceneToLoad
            SceneManager.LoadScene(sceneToLoad);

  
        }
    }
}
