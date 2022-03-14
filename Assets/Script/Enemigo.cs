using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	using CodeMonkey.Utils;
public class Enemigo : MonoBehaviour {
	
	// Use this for initialization
	private int contador;
	private int res;
		private int res2;
	private int res3;
	private int randon;
	public static float health1 =1f;
	public static float vida1=1f;
	public static float ataque1=.25f;
	[SerializeField] private HealthBar healthBar;
	Ecuacion ecuacion;
	Alternativas alternativas;
	Alternativa2 alternativa2;
	Alternativa3 alternativa3;
	 public GameObject target;
	 public GameObject target2;
	
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		if(Alt_correcta.turno==1 && contador==0)
		iniciar();
	}

	IEnumerator Example()
    {
     
        yield return new WaitForSecondsRealtime(3);
		if(contador==0){
	Ecuacion.numero1=Random.Range( 1,99 );
		Ecuacion.numero2=Random.Range( 1,45); 
		Ecuacion.mText.color=Color.black;  
		Ecuacion.resultado=Ecuacion.numero1+Ecuacion.numero2;  
		Ecuacion.mText.text=" "  +Ecuacion.numero1+ "            +          "+Ecuacion.numero2+"     =   "+"???";
    		contador=1;
		res=Ecuacion.resultado+Random.Range(0,4);
		res2=Ecuacion.resultado+Random.Range(0,4);
		res3=Ecuacion.resultado+Random.Range(0,4);
		
		if(res==res2)
		{
		randon=Random.Range(0,1);
			if(randon==0)
			{res=res+Random.Range(1,10);}
		else	{res2=res2+Random.Range(1,10);}
			
		}
		

		if(res2==res3)
			{
				randon=Random.Range(0,1);
				if(randon==0)
				{res2=res2+Random.Range(1,10);}
			else	{res3=res3+Random.Range(1,10);}
		
			}
		if(res==res3)

			{

				randon=Random.Range(0,1);
			if(randon==0)
			{res=res+Random.Range(1,10);}
		else	{res3=res3+Random.Range(1,10);}
		
			}
		if((res!=Ecuacion.resultado) && (res2!=	Ecuacion.resultado) && (res3!= Ecuacion.resultado)){

		randon=Random.Range(1,4);
		if(randon==1)
		res=Ecuacion.resultado;
		else if(randon==2)
		res2=Ecuacion.resultado;
		else	res3=Ecuacion.resultado;}
		        
			Alternativas.result=res;
			
			Alternativa2.result2=res2;
			Alternativa3.result3=res3;
			yield return new WaitForSecondsRealtime(3);		
			if(res==Ecuacion.resultado){	
				Alternativas.Text.color=Color.green;
				Ecuacion.mText.color=Color.green;
				Ecuacion.mText.text="  CORRECTO";
				FunctionPeriodic.Create(() => {
	if(health1>(0)){
	health1-= .01f;
	healthBar.SetSize(health1);
	}
	}, .03f); vida1=health1; Alt_correcta.dano=0;}
			if(res2==Ecuacion.resultado){
				Alternativa2.mText.color=Color.green;
					Ecuacion.mText.color=Color.green;
				Ecuacion.mText.text="  CORRECTO";
FunctionPeriodic.Create(() => {
	if(health1>(0)){
	health1-= .01f;
	healthBar.SetSize(health1);
	}
	}, .03f); vida1=health1; Alt_correcta.dano=0;
}
				
			if(res3==Ecuacion.resultado){
				Alternativa3.mText.color=Color.green;
					Ecuacion.mText.color=Color.green;
				Ecuacion.mText.text="  CORRECTO";
				

			FunctionPeriodic.Create(() => {
	if(health1>(0)){
	health1-= .01f;
	healthBar.SetSize(health1);
	}
	}, .03f); vida1=health1; Alt_correcta.dano=0;
		}
		
	Alt_correcta.turno=0;
	 yield return new WaitForSecondsRealtime(3);
	Destroy(target);
	Destroy(target2);



	
	
	
	
	
	}
	

	
    }
	void iniciar()

	{
	
		StartCoroutine(Example());
		

	}

}
