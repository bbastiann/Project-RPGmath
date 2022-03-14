using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BattleManager : MonoBehaviour
{
    public enum BattleState{EnemyTurn, MyTurn, Attack, AttackResult};
    public BattleState theBattleState  = BattleState.MyTurn;
    public float aResultTimer = 3f;
    public float timeToAtack = 20f;
    public QuestionUI qUI;
    public AlternativeUI[] aUI;
    public Text feedback;
    public GameObject BattleMenu;
    public GameObject QuestionMenu;
    public static int contador;
    public int derrota;
    [System.Serializable]
    public class Question{
        public string QuestionText;
        public string correctAnswer;
        public string[] wrongAnswers;
        public float timeToAnswer = 20;
    }
    public List<Question> AllQList = new List<Question>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<3; i++){
            aUI[i].SetBM(this, i);
        }
        for(int i=0; i<5; i++){
            int operation = Random.Range(0,5);
            int numa = Random.Range(0,99);
            int numb = Random.Range(0,99);
            int result = numa - numb;
            if(operation > 1){
                result = numa + numb;
            }
            Question q = new Question();
            q.QuestionText = "Resuelva la resta " + numa + " - " + numb;
            if(operation > 1){
                q.QuestionText = "Resuelva la suma " + numa + " + " + numb;
            }
            q.correctAnswer = result.ToString();
            q.wrongAnswers = new string[2];
            q.wrongAnswers[0] = (result-Random.Range(4,10)).ToString();
            q.wrongAnswers[1] = (result+Random.Range(4,10)).ToString();
            AllQList.Add(q);
        }
        
    }

    public void StartAttack(){
        theBattleState  = BattleState.Attack;
        Question q = AllQList[0];
        AllQList.RemoveAt(0);
        qUI.SetText(q.QuestionText);
        int j = Random.Range(0,3);
        j = j%3;
        aUI[j].SetText(q.correctAnswer, true);
        for(int i = 1; i<3; i++){
            int iAux = (i+j)%3;            
            aUI[iAux].SetText(q.wrongAnswers[i-1], false);
        }
        aResultTimer = 3;
        timeToAtack = q.timeToAnswer;

    }
    public void Solution(bool isCorrect, int posAlt){

        if(theBattleState == BattleState.Attack){
            if(isCorrect){
                feedback.text = "Correcto!";
		contador=contador+1;
		
            }
            else{
                feedback.text = "Incorrecto!";
		derrota=derrota+1;
            }
            theBattleState = BattleState.AttackResult;
            for(int i = 0; i<3;i++){
                if(posAlt != i){
                    aUI[i].gameObject.SetActive(false);
                }
            }
        }
        else{
            return;
        }

    }

    public void StartMyTurn(){
        theBattleState = BattleState.MyTurn;
        BattleMenu.SetActive(true);
        QuestionMenu.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
	if(derrota==3){
		SceneManager.LoadScene("Aldea");
		derrota=0;}
	if(contador==3){
		SceneManager.LoadScene("Bosque");
		contador=0;}
        if(theBattleState == BattleState.AttackResult){
            aResultTimer-= Time.deltaTime;
	
			
            if(aResultTimer<0){
               StartMyTurn();	
            }
        }
        if(theBattleState == BattleState.Attack){
            timeToAtack -= Time.deltaTime;
            if(timeToAtack<0){
                Solution(false, -1);
            }
        }

        
    }
}
