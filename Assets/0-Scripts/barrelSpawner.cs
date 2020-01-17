using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
   // public PlaneControl plane;
    void Start()
    {
        StartCoroutine(SpawnBarrel());
    }
    void Update()
    {
        transform.Rotate(5, 5 , 0 , Space.World);
    }
    IEnumerator SpawnBarrel()
    {
        while(true)
        {
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(transform.parent.position.x,transform.parent.position.y,35), Quaternion.identity);
       		
	        // pause 1-5 seconds until the next barrel spawns
             yield return new WaitForSeconds(Random.Range(1, 5));
        }
    }
}
