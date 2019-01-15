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
        // sätter isGrounded variablen till ett
        isGrounded = 1;
    }
    // när någonting slutar nudda
    private void OnTriggerExit2D(Collider2D collision)
    {
        // sätter isGrounded variabeln till 0                                                ´Subtraherar det is grounded variablen och visar att inte nuddar något om man faktist inte nuddar nåt
        isGrounded = 0;
    }
}
