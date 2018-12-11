using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTutorial : MonoBehaviour
{

    // Gör en string med namn på en scen som unity ska ladda. (Kan bero på vad man vill skriva här så att man kan ladda flera olika scener)
    public string sceneToLoad = "HowToplay";
    // När Man rör vid en trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Om taggen e player och objectet har trigger så händer det nedan
        if (collision.tag == "Player")
        {

            // Gör så att de laddar sceneToLoad 
            SceneManager.LoadScene(sceneToLoad);


        }
    }
}
