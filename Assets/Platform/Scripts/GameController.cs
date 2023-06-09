using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject[] enemys;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float starWait;
    public float waveWait;
    
    public Text restartText;
    public Text gameOverText;
    public Text inputScoreText;
    public Text timeLifeText;

    private bool restart;
    private bool gameOver;
    private int score = 0;
    public int contadorTime = 180;

    // Start is called before the first frame update
    void Start()
    {   
        restart = false;
        gameOver = false;
        restartText.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        StartCoroutine(SpanWaves());

        timeLifeText.text = string.Format("{0}", contadorTime);
        InvokeRepeating("TimeCounter", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(restart && Input.GetKeyDown(KeyCode.Return)){
            SceneManager.LoadScene("Galaxy_Scene");
        }
    }

    IEnumerator SpanWaves(){
        
        yield return new WaitForSeconds(starWait);

        while(true){
            
             for(int i = 0; i < hazardCount; i++){
                
                GameObject enemy = enemys[Random.Range(0 , enemys.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x , spawnValues.x) , spawnValues.y , spawnValues.z);
                Instantiate(enemy , spawnPosition , Quaternion.identity);
                
                yield return new WaitForSeconds(spawnWait);
            
             }

              yield return new WaitForSeconds(waveWait);

              if(gameOver){
                 
                 restartText.gameObject.SetActive(true);
                 restart = true;
                 break;

              }
        }

    }

    public void GameOver()
    {
        gameOver = true;
        gameOverText.gameObject.SetActive(true);
        timeLifeText.gameObject.SetActive(false);
        CancelInvoke("TimeCounter");

    }

     void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

     public void IncrementScore(){
        
        score++;
        inputScoreText.text = score.ToString();
    }

      public void TimeCounter(){
        contadorTime--;
        if (contadorTime<=0){

            StartCoroutine(detenerCourutine());
        }
        timeLifeText.text = string.Format("{0}", contadorTime);
    }

    IEnumerator detenerCourutine()
    {
        StopCoroutine("SpanWaves");
        gameOverText.text = "Felicidades pasaste al segundo nivel";
        GameOver();
        
        restartText.text = "";
        restartText.gameObject.SetActive(true);

        for(int i = 5; i >= 1; i--){

           restartText.text = "Seras dirigo al segundo nivel en " + i;
           yield return new WaitForSeconds(1f);

        }

        
        SceneManager.LoadScene("Galaxy_Scene2");

    }
}
