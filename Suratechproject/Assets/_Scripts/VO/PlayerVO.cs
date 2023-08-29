using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVO 
{
    public string playerName;
    public int playerAge;
    public int playerAvatar;
    public int currentQuestion;

    public float money;
    public float work;
    public float honor;
    public float relationship;

    public void Plus(ScoreType scoreType, Effect effect)
    {
        float effectScore = 1;
        if (effect == Effect.Direct)
        {

            effectScore = directEffect;
        }
        else
        {
            effectScore = indirectEffect;
        }

        switch(scoreType)
        {
            case ScoreType.Money:
                money += moneyScore * effectScore;
                break;
            case ScoreType.Work:
                work += workScore * effectScore;
                break;
            case ScoreType.Honor:
                honor += hornorScore * effectScore;
                break;
            case ScoreType.Relationship:
                relationship += relationshipScore * effectScore;
                break;

        }
    }
    public void Minus(ScoreType scoreType, Effect effect)
    {
        float effectScore = 1;
        if (effect == Effect.Direct)
        {

            effectScore = directEffect;
        }
        else
        {
            effectScore = indirectEffect;
        }

        switch (scoreType)
        {
            case ScoreType.Money:
                money -= moneyScore * effectScore;
                break;
            case ScoreType.Work:
                work -= workScore * effectScore;
                break;
            case ScoreType.Honor:
                honor -= hornorScore * effectScore;
                break;
            case ScoreType.Relationship:
                relationship -= relationshipScore * effectScore;
                break;

        }
    }

    public enum Effect { Direct,Indirect};
    public enum ScoreType { Money, Work,Honor,Relationship };

    int directEffect = 2;
    int indirectEffect = 1;

    float moneyScore = 3.85f;
    float workScore = 2.78f;
    float hornorScore = 2.17f;
    float relationshipScore = 2.78f;
}
