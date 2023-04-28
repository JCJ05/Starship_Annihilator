using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovimiento : MonoBehaviour
{
    public Transform target; // Objeto de destino (la nave del jugador)
    public float speed = 5f; // Velocidad de movimiento de la nave enemiga

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         // Calcula la posición hacia la que se moverá la nave enemiga
        Vector3 targetPos = new Vector3(target.position.x, transform.position.y, target.position.z);

        // Mueve la nave enemiga hacia la posición objetivo
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        
    }
}
