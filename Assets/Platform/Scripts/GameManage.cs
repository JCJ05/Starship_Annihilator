using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    public GameObject inputGOTarget;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnAparecer", 1f, 1f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAparecer(){
     
       float randomX = Random.Range(-7f,7f);
       float randomY = Random.Range(2.5f,4.1f);

        Vector3 position = new Vector3(randomX,randomY,0);

        Instantiate(inputGOTarget,position, Quaternion.identity);

    }
}
