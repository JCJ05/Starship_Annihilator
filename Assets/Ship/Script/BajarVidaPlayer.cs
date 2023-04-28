using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BajarVidaPlayer : MonoBehaviour

{
    BarraVidaPlayer player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("BarraPlayer").GetComponent<BarraVidaPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other)
    { 

        if(other.CompareTag("Player")) {

            player.disminuirVida();
            Destroy(gameObject);
        }
     }
}
