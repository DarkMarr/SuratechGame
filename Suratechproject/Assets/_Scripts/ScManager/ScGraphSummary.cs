using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
public class ScGraphSummary : MonoBehaviour
{
    [SerializeField] GameObject[] dots;
    [SerializeField] GameObject[] lines;
    [SerializeField] TMP_Text txtName;
    [SerializeField] TMP_Text txtAge;
    [SerializeField] TMP_Text txtCenter;
    [SerializeField] TMP_Text txtTeacher;
    // Start is called before the first frame update
    void Start()
    {
        SetTextData();
        SetDotPosition();
        GenerateGraph();
        SaveData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetTextData()
    {
        PlayerVO player = GameDataService.Instance.myPlayer;
        txtName.text = player.playerName;
        txtAge.text = player.playerAge.ToString()+" ปี";
        txtCenter.text = player.playerCenter;
        txtTeacher.text = player.playerTeacher;
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
        //Base Score 50 + MaxScore 50
        float maxScore = 100f;
        float maxPosition = 175f;
        float result = (maxPosition * score )/ maxScore;
        if (result<0)
        {
            result = 0;
        }
        else if (result> maxPosition)
        {
            result  = maxPosition;
        }

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

    void SaveData()
    {
        string filenName = string.Format("{0}.csv",System.DateTime.Now.ToString("yyyy"));
        string path = Application.dataPath + "/"+ filenName;
        Debug.Log("SaveData >> " + path);
        //Header
        if (!File.Exists(path))
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.UTF8))
            {
                string data = string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\","+
                    "\"{10}\",\"{11}\",\"{12}\",\"{13}\",\"{14}\",\"{15}\",\"{16}\",\"{17}\",\"{18}\",\"{19}\","+ 
                    "\"{20}\",\"{21}\",\"{22}\",\"{23}\",\"{24}\",\"{25}\",\"{26}\",\"{27}\",\"{28}\",\"{29}\","+
                    "\"{30}\",\"{31}\"",
                    "ว/ด/ป",
                    "เวลา",
                    "ชื่อ",
                    "อายุ",
                    "เพศ",
                    "ตัวละคร",
                    "ครู",
                    "ศูนย์",
                    "SPS01",
                    "MSC01",
                    "MSC02",
                    "EMP01",
                    "MSC03",
                    "MSC04",
                    "EMP02",
                    "EMP03",
                    "SPS02",
                    "SPS03",
                    "EMP04",
                    "EMP05",
                    "MSC05",
                    "MSC06",
                    "MSC07",
                    "EMP06",
                    "EMP07",
                    "SPS04",
                    "SPS05",
                    "SPS06",
                    "ด้าน1",
                    "ด้าน2",
                    "ด้าน3",
                    "ด้าน4");
                sw.WriteLine(data);
            }
        }
        using (StreamWriter sw = new StreamWriter(path,true,System.Text.Encoding.UTF8))
        {
            PlayerVO player = GameDataService.Instance.myPlayer;
            int[] answer = GameDataService.Instance.answer;
            string gender = "";
            string charecter = "";
            switch(player.playerAvatar)
            {
                case 1:
                    gender = "ช";
                    charecter = "M1";
                    break;
                case 2:
                    gender = "ช";
                    charecter = "M2";
                    break;
                case 3:
                    gender = "ญ";
                    charecter = "F1";
                    break;
                case 4:
                    gender = "ญ";
                    charecter = "F2";
                    break;

            }
            string data = string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\"," +
                    "\"{10}\",\"{11}\",\"{12}\",\"{13}\",\"{14}\",\"{15}\",\"{16}\",\"{17}\",\"{18}\",\"{19}\"," +
                    "\"{20}\",\"{21}\",\"{22}\",\"{23}\",\"{24}\",\"{25}\",\"{26}\",\"{27}\",\"{28}\",\"{29}\"," +
                    "\"{30}\",\"{31}\"",
                System.DateTime.Now.ToString("dd/MM/yyyy"),
                System.DateTime.Now.ToShortTimeString(),
                player.playerName,
                player.playerAge,
                gender,
                charecter,
                player.playerTeacher,
                player.playerCenter,
                answer[0],
                answer[1],
                answer[2],
                answer[3],
                answer[4],
                answer[5],
                answer[6],
                answer[7],
                answer[8],
                answer[9],
                answer[10],
                answer[11],
                answer[12],
                answer[13],
                answer[14],
                answer[15],
                answer[16],
                answer[17],
                answer[18],
                answer[19],
                player.money, 
                player.work,
                player.honor,
                player.relationship
                );
            sw.WriteLine(data);
        }
    }
}
