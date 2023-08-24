using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataService : Singleton<GameDataService>
{
    PlayerVO myPlayer = new PlayerVO();
    public GameDataService()
    {
        ClearPlayerData();
    }
    public void SaveGameData()
    {

    }

    public void LogPlayerData()
    {
        Debug.LogFormat("Player money = {0},work = {1},honor={2},relationship={3}",myPlayer.money, myPlayer.work, myPlayer.honor, myPlayer.relationship);
    }

    public void ClearPlayerData()
    {
        myPlayer.money = 50;
        myPlayer.work = 50;
        myPlayer.honor = 50;
        myPlayer.relationship = 50;
    }

    public void ScoreProcess(int questionNo,int choiceNo)
    {
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
