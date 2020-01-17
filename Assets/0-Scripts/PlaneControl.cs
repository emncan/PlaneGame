using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlaneControl : MonoBehaviour
{
	public ParticleSystem explosion;
	
    public float speed = 10.0f;
	public int coinTotal = 0;
    private float vertical, horizontal;
	public AudioSource explosionSound;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
   
    void Update()
    {
        PlaneMovement();
	}

    public void PlaneMovement()
    {
        //if (Input.GetAxisRaw("Vertical") != 0) 
        if (CrossPlatformInputManager.GetAxisRaw("Vertical") != 0)
        {
            //vertical = Input.GetAxis("Vertical") * speed;
            vertical = CrossPlatformInputManager.GetAxis("Vertical") * speed;

            // constrain movement within the bounds of the camera
            if (transform.position.y < -20f)
            {
                transform.position = new Vector3(transform.position.x, -20f, transform.position.z);
            }
            if (transform.position.y > 20)
            {
                transform.position = new Vector3(transform.position.x, 20, transform.position.z);
            }
        }
        else
        {
            vertical = 0f;
        }
        //if (Input.GetAxisRaw("Horizontal") != 0) 
        if (CrossPlatformInputManager.GetAxisRaw("Horizontal") != 0)
        {
            //horizontal = Input.GetAxis("Horizontal") * speed;
            horizontal = CrossPlatformInputManager.GetAxis("Horizontal") * speed;

            // constrain movement within the bounds of the camera
            if (transform.position.x < -40f)
            {
                transform.position = new Vector3(-40f, transform.position.y, transform.position.z);
            }
            if (transform.position.x > 40f)
            {
                transform.position = new Vector3(40f, transform.position.y, transform.position.z);
            }
        }
        else
        {
            horizontal = 0f;
        }

        // set rigidbody's velocity to our input
        rb.velocity = new Vector3(horizontal, vertical, 0);
    }
    public void PickupCoin() 
    {
		coinTotal += 1;		
		GetComponents<AudioSource>()[0].Play();		
	}
	public void Explode() 
    {
	     explosionSound.Play();	
		 explosion.transform.position = transform.position;
		 explosion.Play();		
		 Destroy(gameObject);	
	}
}
