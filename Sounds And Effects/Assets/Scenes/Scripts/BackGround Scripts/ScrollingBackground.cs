using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    private Vector3 startPos = new Vector3();
    private float repeatWidth;

    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }
    void Update()
    {
        if(transform.position.x <= startPos.x - repeatWidth){
            transform.position = startPos;
        }
    }
}
