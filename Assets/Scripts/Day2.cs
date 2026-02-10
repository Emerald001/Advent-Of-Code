using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//two stars
public class Day2 : MonoBehaviour
{
    public TextAsset txt;
    int viablePasswords;

    void Start()
    {
        System.DateTime time = System.DateTime.Now;

        var lines = txt.text.Split('\n');

        int[] min = new int[lines.Length];
        int[] max = new int[lines.Length];
        char[] letter = new char[lines.Length];
        string[] password = new string[lines.Length];

        for (int i = 0; i < lines.Length; i++) {
            var tmp = lines[i].Split(':');
            password[i] = tmp[1].Trim(' ');

            var tmp2 = tmp[0].Split(' ')[0].Split('-');

            min[i] = int.Parse(tmp2[0]);
            max[i] = int.Parse(tmp2[1]);

            letter[i] = char.Parse(tmp[0].Split(' ')[1]);
        }

        for (int i = 0; i < lines.Length; i++) {
            char charCout = letter[i];
            var strFirst = password[i];

            //For the first part
            //var count = strFirst.Count(x => x == charCout);

            //if(count >= min[i] && count <= max[i]) {
            //    viablePasswords++;
            //}

            //Second part
            if (strFirst[min[i] - 1] == charCout ^ strFirst[max[i] - 1] == charCout)
                viablePasswords++;
        }
        Debug.Log(viablePasswords);

        System.TimeSpan thiss = System.DateTime.Now - time;
        Debug.Log(thiss.TotalMilliseconds);
    }
}