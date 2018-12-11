using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    // skapar en bool (sant eller falskt) som heter isGrounded
    public int isGrounded;

    // när någonting nuddar objektet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ökar isGrounded variablen och visar att det nuddar något när det gör det
        isGrounded ++;
    }
    // när någonting slutar nudda
    private void OnTriggerExit2D(Collider2D collision)
    {
        // ´Subtraherar det is grounded variablen och visar att inte nuddar något om man faktist inte nuddar nåt
        isGrounded --;
    }
}
