using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        DestroyBarrel();
    }

   private void DestroyBarrel()
    {
        if(transform.position.y< -20 )
           Destroy(gameObject);   
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
