using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;
    public TMP_Text coinText;
    public int currenCoint = 0;

    void Awake()
    {

        instance = this;

    }
    void Start()
    {
        coinText.text = "COINS: " + currenCoint.ToString();
    }

    public void IncreaseCoins(int v)
    {

        currenCoint += v;
        coinText.text = "COINS: " + currenCoint.ToString();

    }

    public void DecreaseCoins()
    {

        currenCoint--;
        coinText.text = "COINS: " + currenCoint.ToString();

    }
}
