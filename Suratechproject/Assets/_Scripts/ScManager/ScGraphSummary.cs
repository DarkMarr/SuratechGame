using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScGraphSummary : MonoBehaviour
{
    [SerializeField] GameObject[] dots;
    [SerializeField] GameObject[] lines;
    // Start is called before the first frame update
    void Start()
    {
        SetDotPosition();
        GenerateGraph();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //0-175
    //0-50
    void SetDotPosition()
    {
        //Relation,Money,Glory,Work
        PlayerVO player = GameDataService.Instance.myPlayer;
        float money = player.money;
        float work = player.work;
        float honor = player.honor;
        float relate = player.relationship;
        dots[0].transform.localPosition = new Vector3(0,ConvertScoreToPixel(relate),0);
        dots[1].transform.localPosition = new Vector3(ConvertScoreToPixel(money), 0,  0);
        dots[2].transform.localPosition = new Vector3(0,-1f* ConvertScoreToPixel(honor), 0);
        dots[3].transform.localPosition = new Vector3(-1f*ConvertScoreToPixel(work), 0,  0);
    }
    float ConvertScoreToPixel(float score)
    {
        float maxScore = 50f;
        float maxPosition = 175f;
        float result = (score/maxScore)*maxPosition;

        return result;
    }
    public void GenerateGraph()
    {
        Vector3 start = new Vector3(0, 0, 0);
        for (int i=0;i<dots.Length;i++)
        {
            if(i==0)
            {
                start = dots[i].transform.localPosition;
                Vector3 end = dots[dots.Length-1].transform.localPosition;
                DrawLine(start, end, lines[i]);
            }
            else
            {
                DrawLine(start, dots[i].transform.localPosition, lines[i]);
                start = dots[i].transform.localPosition;
            }
        }
    }

    void DrawLine(Vector3 start, Vector3 end,GameObject line)
    {
        RectTransform  rec = line.GetComponent<RectTransform>();
        rec.localPosition = (start + end) / 2;
        Vector3 dif = end - start;
        rec.sizeDelta = new Vector3(dif.magnitude, 5);
        rec.rotation = Quaternion.Euler(new Vector3(0, 0, 180 * Mathf.Atan(dif.y / dif.x) / Mathf.PI));
    }
}