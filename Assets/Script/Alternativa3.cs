using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Alternativa3 : MonoBehaviour {

	public static TextMeshProUGUI mText;
	public static int result3;
	private int eleccion;
	private int contad;
	private int randon;
    void Start()
    {
	contad=Alternativas.cont;
        mText = GetComponent<TextMeshProUGUI>();
	eleccion=Ecuacion.resultado;
	result3=Random.Range(0,4);
	result3=result3+eleccion;
	
	
	if(result3==Ecuacion.resultado){
	Alternativas.cont=1;}

	if(Alternativas.cont==1){
	result3=Random.Range(1,5);
	result3=result3+eleccion;}
	
if(Alternativas.result==Alternativa2.result2)
	{
	randon=Random.Range(0,1);
		if(randon==0)
			{Alternativas.result=Alternativas.result+Random.Range(1,10);}
		else	{Alternativa2.result2=Alternativa2.result2+Random.Range(1,10);}
		
	}

	if(Alternativas.result==Alternativa3.result3)
	{
	randon=Random.Range(0,1);
		if(randon==0)
			{Alternativas.result=Alternativas.result+Random.Range(1,10);}
		else	{Alternativa3.result3=Alternativa3.result3+Random.Range(1,10);}
		
	}


	if(Alternativa3.result3==Alternativa2.result2)
	{
	randon=Random.Range(0,1);
		if(randon==0)
			{Alternativa3.result3=Alternativa3.result3+Random.Range(1,10);}
		else	{Alternativa2.result2=Alternativa2.result2+Random.Range(1,10);}
		
	}

	if((Alternativas.result!=Ecuacion.resultado) && (Alternativa2.result2!=Ecuacion.resultado) && (Alternativa3.result3!=Ecuacion.resultado)){
	randon=Random.Range(0,3);
	if(randon==0)
		Alternativas.result=Ecuacion.resultado;
	else if(randon==1)
		Alternativa2.result2=Ecuacion.resultado;
	else
		Alternativa3.result3=Ecuacion.resultado;

}
	}

	void Update ()
	{
	
		


		mText.text=" "+result3;
		
	}
}
