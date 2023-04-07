using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    public Transform[] objectsToMoveTo;
    private int currentTargetIndex = 0;
    public float moveSpeed = 5f;

    void Update()
    {
        if (transform.position == objectsToMoveTo[currentTargetIndex].position)
        {
            if (currentTargetIndex == objectsToMoveTo.Length - 1)
            {
                return;
            }
            else
            {
                currentTargetIndex++;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, objectsToMoveTo[currentTargetIndex].position, moveSpeed * Time.deltaTime);
    }
}


