using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene : MonoBehaviour
{
    [SerializeField] private string newLevel;
    [SerializeField] private int newLevelEntry;
    [SerializeField] private bool combat;
    public int id;
    public static List<int> completedCombats = new List<int>();

    void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player")){

            if(combat){
                if(completedCombats.Contains(id)){
                    return;
                }
                Player.LastPos = transform.position;
                completedCombats.Add(id);
                Player.Combat = true;
            }
            else{
                Player.nextEntry = newLevelEntry;
            }
            SceneManager.LoadScene(newLevel);
        }
    }
}
