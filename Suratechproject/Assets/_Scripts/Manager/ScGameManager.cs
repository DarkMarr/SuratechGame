using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScGameManager : MonoBehaviour
{
    public int MyQuestionNo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoAnswer1()
    {
        int myChoiceNo = 1;
        AnswerProcess(MyQuestionNo,myChoiceNo);
    }
    public void DoAnswer2()
    {
        int myChoiceNo = 2;
        AnswerProcess(MyQuestionNo,myChoiceNo);
    }
    void AnswerProcess(int questionNo,int choiceNo)
    {
        GameDataService.Instance.ScoreProcess(questionNo, choiceNo);
        SceneMan.GoToAnswer(questionNo, choiceNo);
    }
    public void DoGoCharacterSelect()
    {
        SceneMan.GoToCharacterSelect();
    }
}
