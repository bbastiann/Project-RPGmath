using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // Start is called before the first frame update
 
    public void NextScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Se ah salido del juego");
    }
}
