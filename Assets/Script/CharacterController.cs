using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float runspeed = 10f;
    [SerializeField] float walkspeed = 6.5f;
    
    Animator characterAnim;

    bool pressedShift;
    bool right;
    bool left;
  
    Rigidbody2D characterRB;
    Vector3 scale;
    


    private void Awake()
    {
       characterRB = GetComponent<Rigidbody2D>();
        characterAnim = GetComponent<Animator>();
        scale = gameObject.transform.localScale;

    }
    private void Update()
    {

        CharacterControl();



    }
    private void FixedUpdate()
    {
        
        if (right)
        {
            characterRB.velocity = new Vector2(walkspeed, characterRB.velocity.y);
        }
        if (left)
        {
            characterRB.velocity = new Vector2(-walkspeed, characterRB.velocity.y);

        }


    }

    private void CharacterControl()
    {
       
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            characterAnim.SetBool("Walk", true);
            if (scale.x > 0)
            { scale.x *= -1; }
            gameObject.transform.localScale = scale;
            left = true;
        }
        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            characterAnim.SetBool("Walk", false);
            characterRB.velocity = new Vector2(0f, characterRB.velocity.y); 
            left = false;
        }
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            characterAnim.SetBool("Walk", true);
            characterRB.velocity = new Vector2(walkspeed, characterRB.velocity.y);
            if (scale.x < 0)
            { scale.x *= -1; }
            gameObject.transform.localScale = scale;
            right = true;
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            characterAnim.SetBool("Walk", false);
            characterRB.velocity = new Vector2(0f, characterRB.velocity.y);
            right = false;
        }
        
       
    }


    

}
