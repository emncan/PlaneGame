using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static float speed = -35f;
    
 
    void Update()
    {
       
		if (transform.position.x < -45) 
        {
			Destroy(gameObject);
		}
		else 
        {			
			transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
		}
		
		transform.Rotate(0, 5 , 0 , Space.World);
	}
	void OnTriggerEnter(Collider other)
    {        
        if(other.tag =="Player")
        {
	         other.GetComponent<PlaneControl>().PickupCoin();
        
             Destroy(gameObject);
         }

    }	
}
