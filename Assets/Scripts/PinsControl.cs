using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinsControl : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Deadzone"))
        {
            // Destroy the pin
            Destroy(gameObject);
        }
    }
}
