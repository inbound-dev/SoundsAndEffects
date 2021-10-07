using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject objectPrefab;
    private Vector3 spawnPos = new Vector3(5, 0, 0);

    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 2);
    }
    void SpawnObject(){
        Instantiate(objectPrefab, spawnPos, objectPrefab.transform.rotation);
    }
}
