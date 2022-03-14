using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlternativeUI : MonoBehaviour
{
    public BattleManager BM;
    public int pos;
    private string AlternativeText;
    public bool isAnswer;
    public Text textComp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetBM(BattleManager BM, int pos){
        this.BM = BM;
        this.pos = pos;
    }

    public void SetText(string aText, bool isAnswer){
        AlternativeText = aText;
        this.isAnswer = isAnswer;
        textComp.text = aText;
        gameObject.SetActive(true);
    }

    public void Answer(){
        BM.Solution(isAnswer, pos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
