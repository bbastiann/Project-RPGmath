using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Alternativa2 : MonoBehaviour {


	public static TextMeshProUGUI mText;
	public static int result2;
	private int eleccion;
	private int contad;
    void Start()
    {
	contad=Alternativas.cont;
        mText = GetComponent<TextMeshProUGUI>();
	eleccion=Ecuacion.resultado;
	result2=Random.Range(0,4);
	result2=result2+eleccion;
	
	
	if(result2==Ecuacion.resultado){
	Alternativas.cont=1;}
	if(Alternativas.cont==1){
	result2=Random.Range(1,5);
	result2=result2+eleccion;
}}
	void Update ()
	{
	
		mText.text=" "+result2;
		
	}
}