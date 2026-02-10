using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//two stars
public class Day2_2021 : MonoBehaviour
{
    public TextAsset txt;

    void Start()
    {
        System.DateTime time = System.DateTime.Now;

        var lines = txt.text.Split('\n');

        var depth = 0;
        var HorPos = 0;
        var aim = 0;

        for (int i = 0; i < lines.Length; i++) {
            var tmp = lines[i].Split(' ');
            if(tmp[0] == "down")
                aim += int.Parse(tmp[1]);
            if(tmp[0] == "up")
                aim -= int.Parse(tmp[1]);
            if(tmp[0] == "forward") {
                HorPos += int.Parse(tmp[1]);
                depth += aim * int.Parse(tmp[1]);
            }
        }

        Debug.Log(depth * HorPos);

        System.TimeSpan thiss = System.DateTime.Now - time;

        Debug.Log(thiss.TotalMilliseconds);
    }
}
