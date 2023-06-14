using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class JumpScareScript : MonoBehaviour
{
    [SerializeField] GameObject ghost;
    float time = 2;
    bool deactive=false;
    bool hehe = false;
    
    

    void Start()
    {
        ghost.SetActive(false);
       
        
    }

    private void Update()
    { if (hehe == true)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                deactive = true;

            }
            if (deactive == true)
            {
                ghost.SetActive(false);
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ghost.SetActive(true);
           
            hehe = true;
        }

    }
    
}
