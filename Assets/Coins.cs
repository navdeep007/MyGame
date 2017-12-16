using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coins : MonoBehaviour
{
    public Text CoinText;
    static int Coin = 0;

   
   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {

            Destroy(gameObject);
            UpdateCoin();
        }
    }
    public void UpdateCoin()
    {
        Coin++;
        CoinText.text = "Coin:" + Coin;
    }
}