using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    
    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        GameObject explosionInstance = null;
        
        if(other.CompareTag("enemy")) {

            return;
        }

        if(explosion != null){
           
             explosionInstance = Instantiate(explosion , transform.position, transform.rotation);
        }

    
        if(other.CompareTag("Player")){

             GameObject explosionJugador = Instantiate(playerExplosion , other.transform.position, other.transform.rotation);
             Destroy(explosionJugador, 0.3f);
             gameController.GameOver();
        }

      
        Destroy(other.gameObject.GetComponent<Collider2D>().gameObject);
        Destroy(gameObject);
        Destroy(explosionInstance, 0.3f);
        
    }
}
