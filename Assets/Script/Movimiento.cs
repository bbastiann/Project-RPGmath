using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {


	Vector3 change;
	float speed = 15f;
	Rigidbody2D Rigidbody;

	// Use this for initialization
	void Start () {
		Rigidbody=GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update () {
			change=Vector3.zero;
			change.x= Input.GetAxisRaw("Horizontal");
			change.y=  Input.GetAxisRaw("Vertical");
        		if(change != Vector3.zero)
			{
			Move();	
			}
			
	}
	void Move()
        {
        	
		Rigidbody.MovePosition( transform.position + change * speed * Time.deltaTime);

		
        }
}
