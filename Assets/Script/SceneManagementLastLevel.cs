using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagementLastLevel : MonoBehaviour
{
    [SerializeField] GameObject transition;
    [SerializeField] AudioSource activeSound;
    [SerializeField] AudioClip click;
    private float timeLeft = 4.0f;
    bool next;
    int sceneindex;
    private void Start()
    {
        transition.SetActive(false);
        next = false;
        sceneindex = SceneManager.GetActiveScene().buildIndex;
        
    }
    void FixedUpdate()
    {
        if (next == true)
        {
            activeSound.Stop();
           
            timeLeft -= Time.deltaTime;
            transition.SetActive(true);
        }
        if (timeLeft < 0f)
        {
            SceneManager.LoadScene(sceneindex + 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            next = true;
            AudioSource.PlayClipAtPoint(click, collision.transform.position);



        }
    }
}
