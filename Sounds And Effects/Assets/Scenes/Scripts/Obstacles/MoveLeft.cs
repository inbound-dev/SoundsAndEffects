using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public static float speed = 10f;

    private PlayerController PlayerControllerScript;

    void Start(){
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if(PlayerControllerScript.GameOver == false){
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
