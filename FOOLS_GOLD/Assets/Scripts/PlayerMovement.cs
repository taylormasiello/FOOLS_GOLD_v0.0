using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] Rigidbody2D playerRb;
    [SerializeField] Animator animator;

    public Vector3 playerWorldPos;

    Vector2 movement;

    void Update()
    {
        CharMovement();        
    }

    void FixedUpdate()
    {
        Vector3 playerWorldPos = playerRb.transform.position;

        playerRb.MovePosition(playerRb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void CharMovement()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
}
