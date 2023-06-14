using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jester : MonoBehaviour
{
    [SerializeField] GameObject endscreen;
    bool ended;
    [SerializeField] AudioClip audioSource;
    [SerializeField] AudioSource hehe;
    
    void Start()
    {
        endscreen.SetActive(false);
        ended = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0f;
        endscreen.SetActive(true);
        ended = true;
        AudioSource.PlayClipAtPoint(audioSource, collision.transform.position);
        hehe.Stop();
    }
    void Update()
    {if(ended)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
                
            }
        }
        
    }
}
