using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alt2_correcta : MonoBehaviour {

	// Use this for initialization
void Start () {
	if(Alt_correcta.turno==0)
	{
	if(Alternativa2.result2==Ecuacion.resultado){
		Alt_correcta.dano=1;	
		Ecuacion.mText.text="CORRECTO";
		Ecuacion.mText.color=Color.green;
		Alt_correcta.turno=1;
		}
		else{ Ecuacion.mText.text="        ERROR  ";
		Ecuacion.mText.color=Color.red;
		Alt_correcta.turno=1;}
	}
}
	// Update is called once per frame
	void Update () {
		
	}
}
