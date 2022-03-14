using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Entrada : MonoBehaviour {
	GameObject Player;
	// Use this for initialization
	void Start () {
	Player = GameObject.FindGameObjectWithTag("player");	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
{

	Debug.Log("hola");
	
	SceneManager.LoadScene("Batalla");
	if(other.CompareTag("Player") && !other.isTrigger)
	{
		Application.LoadLevel("Batalla");
		Application.Quit();
		
 	}

}

}
