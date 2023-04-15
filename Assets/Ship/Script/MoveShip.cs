using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    public float velocidadHorizontal = 5f;
    public float velocidadVertical = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
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

        transform.Translate(new Vector3(movimientoHorizontal, movimientoVertical, 0f));

    }
}
