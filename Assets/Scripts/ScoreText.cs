using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{ 
    // skaffar in text
    private TextMeshProUGUI text;

    // Use this for initialization
    void Start()
    {
        // hämtar text mesh komponent
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // visar score på hud:en går upp när man går in i ett coin (Coin.score) genom coin scriptet
        text.text = string.Format("Score: {0:0000}", Coin.score);
    }
}
