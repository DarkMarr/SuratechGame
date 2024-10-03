using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameDataService : Singleton<GameDataService>
{
    public PlayerVO myPlayer = new PlayerVO();
    public int[] answer = new int[20];
    public int[] questionList = new int[20];
    public GameDataService()
    {
        
    }
    public void SaveGameData()
    {

    }
    void Start()
    {
        ClearPlayerData();
    }

    public void LogPlayerData()
    {
        Debug.LogFormat("Player money = {0},work = {1},honor={2},relationship={3}",myPlayer.money, myPlayer.work, myPlayer.honor, myPlayer.relationship);
    }

    public void ClearPlayerData()
    {
        myPlayer.playerName = "นิรนาม";
        myPlayer.playerCenter = "ศูนย์นิรนาม";
        myPlayer.playerTeacher = "ครูนิรนาม";
        myPlayer.playerAge = 3;
        myPlayer.money = 50;
        myPlayer.work = 50;
        myPlayer.honor = 50;
        myPlayer.relationship = 50;
        myPlayer.currentQuestion = 1;
        myPlayer.playerAvatar = 0;
        ClearAnswer();
        questionList = GenerateQustionList();
    }

    void ClearAnswer()
    {
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = 0;
        }
    }

    int[] GenerateQustionList()
    {
        List<int> result = new List<int>();

        int qPerRound = 4;
        int[] q1 = new int[qPerRound];
        int startValue = 1;
        for (int i = 0; i < q1.Length; i++)
        {
            q1[i] = i + startValue;
        }
        q1 = Shuffle(q1);
        for (int i = 0; i < q1.Length; i++)
        {
            result.Add(q1[i]);
        }

        int[] q2 = new int[qPerRound];
        startValue += qPerRound;
        for (int i = 0; i < q2.Length; i++)
        {
            q2[i] = i + startValue;
        }
        q2 = Shuffle(q2);
        for (int i = 0; i < q2.Length; i++)
        {
            result.Add(q2[i]);
        }

        int[] q3 = new int[qPerRound];
        startValue += qPerRound;
        for (int i = 0; i < q3.Length; i++)
        {
            q3[i] = i + startValue;
        }
        q3 = Shuffle(q3);
        for (int i = 0; i < q3.Length; i++)
        {
            result.Add(q3[i]);
        }

        int[] q4 = new int[qPerRound];
        startValue += qPerRound;
        for (int i = 0; i < q4.Length; i++)
        {
            q4[i] = i + startValue;
        }
        q4 = Shuffle(q4);
        for (int i = 0; i < q4.Length; i++)
        {
            result.Add(q4[i]);
        }

        int[] q5 = new int[qPerRound];
        startValue += qPerRound;
        for (int i = 0; i < q5.Length; i++)
        {
            q5[i] = i + startValue;
        }
        q5 = Shuffle(q4);
        for (int i = 0; i < q5.Length; i++)
        {
            result.Add(q5[i]);
        }
        string log = "Question List = ";
        for (int i = 0; i < result.Count; i++)
        {
           log += result[i]+",";
        }
        Debug.Log(log);
        return result.ToArray();
    }


    int[] Shuffle(int[]  input)
    {
        int[]  ts = input;
        int count = ts.Length;
        var last = count - 1;
        for (var i = 0; i < last; ++i)
        {
            var r = Random.Range(i, count);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }

        return ts;
    }
    public void ScoreProcess(int questionNo,int choiceNo)
    {
        answer[questionNo-1] = choiceNo;
        switch (questionNo)
        {
            case 1:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Plus(PlayerVO.ScoreType.Work,PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 2:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Plus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 3:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Plus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 4:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Plus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 5:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 6:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Plus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 7:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 8:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 9:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Plus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 10:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Plus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 11:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 12:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Indirect);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 13:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Direct);
                        break;
                    case 2:
                        myPlayer.Plus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Direct);
                        break;
                }
                break;
            case 14:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Direct);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);

                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Direct);
                        break;
                }
                break;
            case 15:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);


                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Direct);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);

                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Direct);
                        break;
                }
                break;
            case 16:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Direct);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Direct);
                        break;
                }
                break;
            case 17:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Plus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 18:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Plus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
            case 19:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Plus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        break;
                }
                break;
            case 20:
                switch (choiceNo)
                {
                    case 1:
                        myPlayer.Plus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Indirect);
                        myPlayer.Plus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Plus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                    case 2:
                        myPlayer.Minus(PlayerVO.ScoreType.Money, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Work, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Honor, PlayerVO.Effect.Direct);
                        myPlayer.Minus(PlayerVO.ScoreType.Relationship, PlayerVO.Effect.Indirect);
                        break;
                }
                break;
        }
    }
}
