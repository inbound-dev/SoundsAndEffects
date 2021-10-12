using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBounding : MonoBehaviour
{
    private float leftBound = -15;

    void Update()
    {
        if(transform.position.x < leftBound){
            Destroy(gameObject);
        }
    }
}
