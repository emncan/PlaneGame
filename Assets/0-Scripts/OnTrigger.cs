using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
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