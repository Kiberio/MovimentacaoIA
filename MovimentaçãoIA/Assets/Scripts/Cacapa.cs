using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cacapa : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bola"))
        {
            Destroy(other.gameObject);
        }
    }
}
