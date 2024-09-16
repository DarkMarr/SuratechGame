using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCharacterManager : MonoBehaviour
{
    [SerializeField] GameObject boySounds;
    [SerializeField] GameObject girlSounds;
    // Start is called before the first frame update
    void Start()
    {
        PlaySound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //int avartarId = GameDataService.Instance.myPlayer.playerAvatar;
    void PlaySound()
    {
        int avartarId = GameDataService.Instance.myPlayer.playerAvatar;
        //0,1 Boy
        //2,3 Girl
        if (avartarId == 0 || avartarId == 1)
        {
            boySounds.SetActive(true);
            girlSounds.SetActive(false);
        }
        else
        {
            boySounds.SetActive(false);
            girlSounds.SetActive(true);
        }
    }
}
