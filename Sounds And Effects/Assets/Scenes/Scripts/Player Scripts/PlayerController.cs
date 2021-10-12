using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRB;
    
    public float GravityModifier;
    public float JumpForce;

    public bool isOnGround;
    public bool GameOver = false;

    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
        Physics.gravity *= GravityModifier;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround == true){
            PlayerRB.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround = true;
        }
        else if(collision.gameObject.CompareTag("Obstacle")){
            GameOver = true;
            Debug.Log("Game Over!");
        }
    }
}
