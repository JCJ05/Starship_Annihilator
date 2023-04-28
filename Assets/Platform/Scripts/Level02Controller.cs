using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level02Controller : MonoBehaviour
{

    
    public Text message;
    GameObject gameOver;
    GameObject gameFin;

    void Start()
    {
        gameOver = GameObject.Find("game_over_fin");
        gameFin = GameObject.Find("message_win");

        gameOver.SetActive(false);
        gameFin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void FinJuego()
    {
        StartCoroutine(ShowWinDelayed());
    }

    public void WinGame(){
         StartCoroutine(GanadorPlayer());
    }

    IEnumerator ShowWinDelayed()
    {   
        
        gameOver.SetActive(true);
        message.text = "Regresando al menu inicial";
        yield return new WaitForSeconds(5f); 

        SceneManager.LoadScene("Menu_Inicial");
        
    }

     IEnumerator GanadorPlayer()
    {   
        gameFin.SetActive(true);
        message.text = "Ganaste, muchas gracias por participar";
        yield return new WaitForSeconds(5f); 

        SceneManager.LoadScene("Creditos_Escena");
        
    }
}
