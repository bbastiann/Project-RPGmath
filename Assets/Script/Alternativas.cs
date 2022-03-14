using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Alternativas : MonoBehaviour 
{

	public static TextMeshProUGUI Text;
	public static int result;
	public static int cont;
	private int eleccion;
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
	eleccion=Ecuacion.resultado;
	result=Random.Range(0,4);
	result=result+eleccion;
	if(result==Ecuacion.resultado){
	cont=1;}
	if(cont==1){
	result=Random.Range(1,5);
	result=result+eleccion;
	
}}
	void Update ()
	{
	Text.text=" "+result;
		
		
	}
}