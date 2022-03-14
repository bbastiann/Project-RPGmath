using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public class GameHandler : MonoBehaviour {
	public static float health =1f;
	public static float vida=1f;
	public static float ataque=.25f;
	[SerializeField] private HealthBar healthBar;
void Start () {
		
	if(Alt_correcta.dano==1){
	FunctionPeriodic.Create(() => {
	if(health>(vida-ataque)){
	health-= .01f;
	healthBar.SetSize(health);
	}
	}, .03f); vida=health; Alt_correcta.dano=0;

}
}


	// Update is called once per frame
	void Update () {
		
	}
}
