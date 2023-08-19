using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    private KeyCode lastHitKey;
    public Animator animator;

    void Start()
    {
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the new position based on input and speed
        Vector3 newPosition = transform.position + new Vector3(horizontalInput * moveSpeed * Time.deltaTime, verticalInput * moveSpeed * Time.deltaTime, 0f);
        if (isMoving())
        {
            Debug.Log("Moving");
            animator.SetBool("isRunning", true);
        }
        else 
        {      
            animator.SetBool("isRunning", false);
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            Debug.Log("attacking");
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }



        // Update the player's position
        transform.position = newPosition;
    }

    private bool isMoving()
    {
        return Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected!");
    }

}   

