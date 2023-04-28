using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoController2 : MonoBehaviour
{
    public GameObject shot;
    public Transform shotDire;
    public float delay;
    public float fireRate;
    private bool canFire = true;
    private float timer = 0;

void Start()
{
    timer = delay; // Iniciar temporizador
}

void Update()
{
    timer -= Time.deltaTime; // Actualizar temporizador
    if (timer <= 0f && canFire) // Comprobar si el temporizador ha terminado y si la nave enemiga puede disparar
    {
        Fire();
        timer = fireRate; // Reiniciar temporizador
    }
}

void Fire()
{
    Instantiate(shot, shotDire.position, shotDire.rotation);
    canFire = true; // Permitir que la nave enemiga dispare de nuevo
}
    
}
