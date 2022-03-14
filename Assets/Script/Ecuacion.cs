using UnityEngine;
using System.Collections;
using TMPro;

public class Ecuacion : MonoBehaviour
{

	public static TextMeshProUGUI mText;
	public static int numero1;
	public static int numero2;
	public static int resultado;
	public static int correcto;

    void Start()
    {
        mText = GetComponent<TextMeshProUGUI>();
	numero1=Random.Range( 1,99 );
	numero2=Random.Range( 1,45);   
	resultado=numero1+numero2;  
			mText.text=" "  +numero1+ "            +          "+numero2+"     =   "+"???";
}
	void Update ()
	{

		
	}
}