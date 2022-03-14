using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionUI : MonoBehaviour
{
    private string questionText;
    public Text textComp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetText(string qText){
        questionText = qText;
        textComp.text = qText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
