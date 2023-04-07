using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform[] targets; // Array contendo os 6 objetos

    public float speed; // Velocidade de movimento do player

    private int currentTargetIndex = 0; // Índice do objeto atual

    void Update()
    {
        // Verifica se o player chegou ao objeto atual
        if (transform.position == targets[currentTargetIndex].position)
        {
            // Atualiza o índice do objeto atual
            currentTargetIndex++;

            // Verifica se atingiu o fim do array de objetos
            if (currentTargetIndex >= targets.Length)
            {
                // Volta ao início do array
                currentTargetIndex = 0;
            }
        }

        // Move o player em direção ao objeto atual
        transform.position = Vector3.MoveTowards(transform.position, targets[currentTargetIndex].position, speed * Time.deltaTime);
    }
}
