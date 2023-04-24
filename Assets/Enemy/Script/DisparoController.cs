using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoController : MonoBehaviour
{
    public GameObject shot;
    public Transform shotDire;
    public float delay;
    public float fireRate;
    // Start is called before the first frame update
    void Start()
    {
         Invoke("DestroyObject", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("Fire" , delay , fireRate);
    }

    void Fire()
    {
        Instantiate(shot , shotDire.position , shotDire.rotation);
    }

    void DestroyObject()
{
    Destroy(gameObject); // Destruye el objeto al que está adjuntado este script
}
}
