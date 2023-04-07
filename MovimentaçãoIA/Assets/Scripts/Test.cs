using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform[] targets; // Array contendo os 6 objetos

    public float speed; // Velocidade de movimento do player

    private int currentTargetIndex = 0; // �ndice do objeto atual

    void Update()
    {
        // Verifica se o player chegou ao objeto atual
        if (transform.position == targets[currentTargetIndex].position)
        {
            // Atualiza o �ndice do objeto atual
            currentTargetIndex++;

            // Verifica se atingiu o fim do array de objetos
            if (currentTargetIndex >= targets.Length)
            {
                // Volta ao in�cio do array
                currentTargetIndex = 0;
            }
        }

        // Move o player em dire��o ao objeto atual
        transform.position = Vector3.MoveTowards(transform.position, targets[currentTargetIndex].position, speed * Time.deltaTime);
    }
}
