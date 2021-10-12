using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject objectPrefab;
    private Vector3 spawnPos = new Vector3(5, 0, 0);

    private PlayerController PlayerControllerScript;

    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        InvokeRepeating("SpawnObject", 2, 2);
    }
    void SpawnObject(){
        if(PlayerControllerScript.GameOver == false){
            Instantiate(objectPrefab, spawnPos, objectPrefab.transform.rotation);
        }
    }
}
