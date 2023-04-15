using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    public float velocidadHorizontal = 5f;
    public float velocidadVertical = 5f;
    public float limiteIzquierdo;
    public float limiteDerecho;
    public float limiteInferior;
    public float limiteSuperior;
    public float velocidadFondoVertical = 1f;

    // Start is called before the first frame update
    void Start()
    {

        limiteInferior = -4.399358f;
        limiteSuperior = 4.278425f;
        limiteIzquierdo = -6.92664f;
        limiteDerecho = 6.829587f;
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = 0f;
        float movimientoVertical = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movimientoHorizontal = -velocidadHorizontal * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            movimientoHorizontal = velocidadHorizontal * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            movimientoVertical = -velocidadVertical * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            movimientoVertical = velocidadVertical * Time.deltaTime;
        }

        float nuevaPosicionX = Mathf.Clamp(transform.position.x + movimientoHorizontal, limiteIzquierdo, limiteDerecho);
        float nuevaPosicionY = Mathf.Clamp(transform.position.y + movimientoVertical, limiteInferior, limiteSuperior);

        transform.position = new Vector3(nuevaPosicionX, nuevaPosicionY, transform.position.z);
        

    }
}
