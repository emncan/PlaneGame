using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBomb());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnBomb()
    {
        while(true)
        {
        	Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(60, Random.Range(-7, 7), 35), Quaternion.identity);
			// pause 6 seconds until the next bomp spawns
			yield return new WaitForSeconds(6);
        }
}
}