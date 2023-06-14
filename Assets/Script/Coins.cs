using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Coins : MonoBehaviour
{
    [SerializeField] AudioClip coinSound;
    [SerializeField]  TextMeshProUGUI collectedCoin;
    
    public int coinNumber;
    private void Start()
    {
        coinNumber = 0;
    }
    private void Update()
    {


        collectedCoin.text = coinNumber.ToString();
        
        
           
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coinNumber++;
            AudioSource.PlayClipAtPoint(coinSound, collision.transform.position);
            Destroy(collision.gameObject);
        }
    }
}
