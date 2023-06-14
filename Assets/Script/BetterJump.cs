using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class BetterJump : MonoBehaviour
{
    [SerializeField] float fallMult = 2.5f;
    [SerializeField] float lowJumpMult = 2f;
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {
        if(rb.velocity.y < 0)
        {
            rb.velocity = rb.velocity + (Vector2.up * Physics2D.gravity.y * (fallMult - 1) * Time.deltaTime);
        }
        else if(rb.velocity.y > 0)
        {
            rb.velocity = rb.velocity + (Vector2.up * Physics2D.gravity.y * (lowJumpMult - 1) * Time.deltaTime);
        }
    }
}
