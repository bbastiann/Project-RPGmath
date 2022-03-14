using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alt_correcta : MonoBehaviour {

	// Use this for initialization
	public static int dano;
	public static int turno;
	void Start () {
	if(turno==0){
	if(Alternativas.result==Ecuacion.resultado){
	dano=1;	
	Ecuacion.mText.text="CORRECTO";
	Ecuacion.mText.color=Color.green;
	turno=1;

}
	else{ Ecuacion.mText.text="        ERROR  ";
	Ecuacion.mText.color=Color.red;
	turno=1;}

}
}
	// Update is called once per frame
	void Update () {
		
	}
	void eleccion1(){}


	void eleccion2(){}
	void eleccion3(){}
}
