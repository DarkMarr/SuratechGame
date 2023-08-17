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
        SceneMan.GoToAnswer(MyQuestionNo, 1);
    }
    public void DoAnswer2()
    {
        SceneMan.GoToAnswer(MyQuestionNo, 2);
    }
}
