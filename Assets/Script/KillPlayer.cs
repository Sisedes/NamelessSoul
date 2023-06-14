using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] GameObject deathMenu;
    
    bool stopped;
    private void Start()
    {
        deathMenu.SetActive(false);
        stopped = false;
    }
    private void Update()
    {
        if (stopped)
        {
            if (Input.GetKeyDown(KeyCode.R))
            { SceneManager.LoadScene(1);
                stopped = false;
                Time.timeScale = 1f;

            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            { SceneManager.LoadScene(0);
                stopped = false;
                Time.timeScale = 1f;

            }

        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            deathMenu.SetActive(true);
            Time.timeScale = 0f;
            stopped=true;
        }
    }
}
