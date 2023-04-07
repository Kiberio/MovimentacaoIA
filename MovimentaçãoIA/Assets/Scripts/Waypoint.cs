using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Material[] materials;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Material randomMaterial = GetRandomMaterial();
            this.GetComponent<Renderer>().material = randomMaterial;
        }
    }

    private Material GetRandomMaterial()
    {
        int randomIndex = Random.Range(0, materials.Length);
        return materials[randomIndex];
    }

}
