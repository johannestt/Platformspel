using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelWin : MonoBehaviour
{
    // Gör en string med namn på en scen som unity ska ladda. (Kan bero på vad man vill skriva här så att man kan ladda flera olika scener)
    public string sceneToLoad = "WinningScene";
    // När Man rör vid en trigger så händer det under
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om Player rör flaggan i detta fallet så laddar han nästa bana
        if (collision.tag == "Player")
        {

            // Gör så att de laddar sceneToLoad 
            SceneManager.LoadScene(sceneToLoad);


        }
    }
}

