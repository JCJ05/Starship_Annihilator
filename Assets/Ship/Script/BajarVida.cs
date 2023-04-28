using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BajarVida : MonoBehaviour
{

     BarraDeVida vida;

    // Start is called before the first frame update
    void Start()
    {
        vida = GameObject.Find("EventSystem").GetComponent<BarraDeVida>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other)
    { 

        if(other.CompareTag("nodriza")) {

            vida.disminuirVida();
            Destroy(gameObject);
        }
     }
}
