using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
   
    public static float speed = -45f;
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
		transform.Rotate(5, 5 , 5 , Space.World);
	}


	void OnTriggerEnter(Collider other)
    {		       
        if(other.tag =="Player")
        {
	        other.GetComponent<PlaneControl>().Explode();
            GameObject UI = GameObject.FindGameObjectWithTag("UserInterface");
            UI.GetComponent<UIController>().GameOver();
            Destroy(gameObject);
        }

    }	
}
