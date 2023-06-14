using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;
    Rigidbody2D EnemyRB;
    BoxCollider2D EnemyBoxCollider;
    

    private void Awake()
    {
        EnemyRB = GetComponent<Rigidbody2D>();
        EnemyBoxCollider=GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (IsFacingRight())
        {
            EnemyRB.velocity = new Vector2(moveSpeed, 0f);
        }
        else
        {
            EnemyRB.velocity = new Vector2(-moveSpeed, 0f);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.localScale=new Vector2(-(Mathf.Sign(EnemyRB.velocity.x)),transform.localScale.y);
        

    }
    private bool IsFacingRight()
    {

        return transform.localScale.x > Mathf.Epsilon;
    }
    
}
