using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVidaPlayer : MonoBehaviour
{
    public Image barraDeVida;
    public float vidaActual;
    public float vidaMaxima;

    public GameObject explosionPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
    }

     public void disminuirVida(){

        vidaActual -= 10;

        if(vidaActual <= 0){
            
            

            GameObject barra = GameObject.Find("life_player");
            Destroy(barra);

            GameObject explosionInstance = Instantiate(explosionPlayer , transform.position, transform.rotation);
            Destroy(gameObject);

            GameObject objetoAEliminar = GameObject.Find("Ship_Aniquilator");
            Destroy(objetoAEliminar);

            GameObject objetoAEliminar2 = GameObject.Find("Cap_Enemy");
            Destroy(objetoAEliminar2);

            GameObject objeto = GameObject.Find("GameObjectMesage");
            objeto.GetComponent<Level02Controller>().FinJuego();
        }
    }
}
