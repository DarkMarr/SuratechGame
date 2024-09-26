using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScSelectTarget : MonoBehaviour
{
    [SerializeField] GameObject[] targets;
    [SerializeField] GameObject[] Chooses;
    int[] targetsChoose = new int[4];
    Sprite[] emptyTargets = new Sprite[4];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int GetNextTarget()
    {
        int result = 0;
        for (int i = 0; i < targetsChoose.Length; i++)
        {
            if (targetsChoose[i] == 0)
            {
                result = i;
                break;
            }
        }
        return result;
    }

    public void DoChoose1()
    {
        int myChoice = 1;
        ChooseProcess(myChoice);
    }
    public void DoChoose2()
    {
        int myChoice = 2;
        ChooseProcess(myChoice);
    }
    public void DoChoose3()
    {
        int myChoice = 3;
        ChooseProcess(myChoice);
    }
    public void DoChoose4()
    {
        int myChoice = 4;
        ChooseProcess(myChoice);
    }

    void ChooseProcess(int choice)
    {
        int indexChoose = choice - 1;
        Sprite img = Chooses[indexChoose].GetComponent<Image>().sprite;
        Chooses[indexChoose].GetComponent<Button>().interactable = false;
        int indexTarget = GetNextTarget();
        emptyTargets[indexTarget] = targets[indexTarget].GetComponent<Image>().sprite;
        targets[indexTarget].GetComponent<Image>().sprite = img;
        targets[indexTarget].GetComponentInChildren<TMP_Text>().enabled = false;
        targetsChoose[indexTarget] = choice;
    }
    public void DoTarget1()
    {
        int curTarget = 1;
        TargetProcess(curTarget);
    }
    public void DoTarget2()
    {
        int curTarget = 2;
        TargetProcess(curTarget);
    }
    public void DoTarget3()
    {
        int curTarget = 3;
        TargetProcess(curTarget);
    }
    public void DoTarget4()
    {
        int curTarget = 4;
        TargetProcess(curTarget);
    }

    void TargetProcess(int curTarget)
    {
        int indexTarget = curTarget - 1;
        int indexChoose = targetsChoose[indexTarget]-1;
        if (indexChoose >= 0)
        {
            Chooses[indexChoose].GetComponent<Button>().interactable = true;
            targets[indexTarget].GetComponent<Image>().sprite = emptyTargets[indexTarget];
            targets[indexTarget].GetComponentInChildren<TMP_Text>().enabled = true;
        }
        targetsChoose[indexTarget] = 0;
    }
}
