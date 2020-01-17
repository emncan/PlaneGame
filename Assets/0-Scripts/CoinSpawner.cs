using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoins());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCoins()
    {
        while(true)
        {
            // number of coins we could spawn vertically
			int coinsThisRow = Random.Range(1, 4);

			// instantiate all coins in this row separated by some random amount of space
			for (int i = 0; i < coinsThisRow; i++) {
				Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(56, Random.Range(-15, 10), 35), Quaternion.identity);
			}

			// pause 2-6 seconds until the next coin spawns
			yield return new WaitForSeconds(Random.Range(2,6));
        }
    }
}
