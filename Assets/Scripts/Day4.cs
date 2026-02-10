using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//tried But no success
public class Day4 : MonoBehaviour
{
    public TextAsset txt;
    int validFound;

    string[] numerals = {
        "byr",
        "iyr",
        "eyr",
        "hgt",
        "hcl",
        "ecl",
        "pid"
    };

    void Start() {
        System.DateTime time = System.DateTime.Now;

        var lines = txt.text.Split('\r');

        for (int i = 0; i < lines.Length; i++) {
            var tmp = lines[i].Split(' ');

            var count = 0;
            for (int j = 0; j < tmp.Length; j++) {
                for (int k = 0; k < numerals.Length; k++) {
                    if (tmp[j].Contains(numerals[k])) {
                        count++;
                        break;
                    }
                }
            }
            if (count > 6) {
                validFound++;
            }
        }

        Debug.Log(validFound);

        System.TimeSpan thiss = System.DateTime.Now - time;
        Debug.Log(thiss.TotalMilliseconds);
    }
}
