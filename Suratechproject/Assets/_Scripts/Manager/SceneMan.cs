using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : Singleton<SceneMan>
{
    public static void GoToScence(int question,int choice)
    {
        string suffix = "";
        if(choice>0)
        {
            suffix = string.Format("_{0}",choice.ToString("00"));
        }
        string scenceName = string.Format("S_{0}{1}",question.ToString("00"),suffix);
        SceneManager.LoadScene(scenceName);
    }

    public static void GoToQuestion(int questionNo)
    {
        GameDataService.Instance.myPlayer.currentQuestion = questionNo;
        GoToScence(questionNo, 0);
    }

    public static void GoToAnswer(int questionNo, int answerNo)
    {
        GoToScence(questionNo, answerNo);
    }

    public static void GoToTitle()
    {
        SceneManager.LoadScene("title");
    }
    public static void GoToIntro()
    {
        SceneManager.LoadScene("Intro");
    }
    public static void GoToCharacterSelect()
    {
        SceneManager.LoadScene("CharacterSelect");
    }
    public static void GoToInputPlayerData()
    {
        SceneManager.LoadScene("InputPlayerData");
    }
    public static void GoToSelectTarget()
    {
        SceneManager.LoadScene("SelectTarget");
    }
    public static void GoToWorldMap()
    {
        SceneManager.LoadScene("Worldmap");
    }
    public static void GoToGameScore()
    {
        SceneManager.LoadScene("GameScore");
    }
    public static void GoToGraphSummary()
    {
        SceneManager.LoadScene("GraphSummary");
    }
    public static void GoToOutro()
    {
        SceneManager.LoadScene("Outro");
    }

    public static void GoToNextScenceByIndex()
    {
        int cur = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(cur+1, LoadSceneMode.Single);
    }

}
