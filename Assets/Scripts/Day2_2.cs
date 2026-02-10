using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//two stars
public class Day2_2 : MonoBehaviour
{
    public TextAsset txt;
    int viablePasswords;

    void Start()
    {
        System.DateTime time = System.DateTime.Now;

        var lines = txt.text.Split('\n');

        for (int i = 0; i < lines.Length; i++) {
            var tmp = lines[i].Split(':');
            var tmp2 = tmp[0].Split(' ')[0].Split('-');

            if (tmp[1].Trim(' ')[int.Parse(tmp2[0]) - 1] == char.Parse(tmp[0].Split(' ')[1]) ^ tmp[1].Trim(' ')[int.Parse(tmp2[1]) - 1] == char.Parse(tmp[0].Split(' ')[1]))
                viablePasswords++;
        }

        System.TimeSpan thiss = System.DateTime.Now - time;
        Debug.Log(thiss.TotalMilliseconds);

        Debug.Log(viablePasswords);
    }
}