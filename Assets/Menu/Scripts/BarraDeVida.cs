using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Image barraDeVida;
    public float vidaActual;
    public float vidaMaxima;

    public GameObject explosion;

    // Update is called once per frame
    void Update()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
        Debug.Log(vidaActual);
    }

    public void disminuirVida(){

        vidaActual -= 10;

        if(vidaActual <= 0){
            
            GameObject objetoAEliminar = GameObject.Find("Cap_Enemy");
            Destroy(objetoAEliminar);

            GameObject barra = GameObject.Find("Background_life");
            Destroy(barra);


            GameObject explosionInstance = Instantiate(explosion , transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
