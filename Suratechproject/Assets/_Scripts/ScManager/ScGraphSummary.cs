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
        GenerateGraph();
    }

    // Update is called once per frame
    void Update()
    {
        
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
