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
        GoToScence(questionNo, 0);
    }

    public static void GoToAnswer(int questionNo, int answerNo)
    {
        GoToScence(questionNo, answerNo);
    }

    public static void GoToBreakingNews()
    {
        SceneManager.LoadScene("Land_A_Breaking_News");
    }
}
