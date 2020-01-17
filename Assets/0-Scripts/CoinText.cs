using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CoinText : MonoBehaviour
{
    public GameObject plane;
	private Text text; 
	private int coins;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        SetCoinText();
    }

    private void SetCoinText()
    {
        if(plane != null)
        {
            coins = plane.GetComponent<PlaneControl>().coinTotal;
        }
        text.text = "Coins: " + coins;
    }
}
