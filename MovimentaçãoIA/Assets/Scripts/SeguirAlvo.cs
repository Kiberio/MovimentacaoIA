using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirAlvo : MonoBehaviour
{
    //Vector3 goal = new Vector3(-3, 1, 0);
    public float speed = 1.0f;
    public Transform goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = goal.position - this.transform.position;
        this.transform.Translate(direction.normalized*speed*Time.deltaTime);
    }
}
