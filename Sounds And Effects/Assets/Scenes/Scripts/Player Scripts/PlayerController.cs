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

    private Animator playerAnim;

    public ParticleSystem explosionParticle;

    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= GravityModifier;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround == true && !GameOver){
            PlayerRB.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
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
            
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);

            explosionParticle.Play();
        }
    }
}
