using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] float jumpVelocity;
    Animator animator;
    private BoxCollider2D coll;
    [SerializeField] LayerMask jumpableGround;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        coll=GetComponent<BoxCollider2D>();
        
    }

    void Update()
    {
        Jumped();
        
            
        
        
    }

    void Jumped()
    {
        if ((Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.UpArrow)) && IsGrounded())
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
            animator.SetTrigger("Jump");

            animator.SetBool("Grounded", false);
            
        }
    }


     
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("Grounded", true);
        }
        
    }

    private bool IsGrounded()
    {
       return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}

