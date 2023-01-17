using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter Instance;

    public TMP_Text coinText;
    public int currentCoins = 0;

    public void Awake()
    {
        Instance = this;
    }

    public void start()
    {
        coinText.text = "Coins: " + currentCoins.ToString();
    }

    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "Coins: " + currentCoins.ToString();
    }
}