using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//two stars
public class Day1_2021 : MonoBehaviour
{
    public TextAsset txt;

    int increaseAmount;

    void Start()
    {
        System.DateTime time = System.DateTime.Now;

        var lines = txt.text.Split('\n');

        var lastSum = 0;
        var FirstValue = 0;
        var SecondValue = 0;

        for (int i = 0; i < lines.Length; i++) {
            if (lastSum == 0) {
                if(SecondValue == 0) {
                    SecondValue = FirstValue;
                    FirstValue = int.Parse(lines[i]);
                    continue;
                } else {
                    lastSum = SecondValue + FirstValue + int.Parse(lines[i]);
                    SecondValue = FirstValue;
                    FirstValue = int.Parse(lines[i]);
                    continue;
                }
            }

            if (lastSum < SecondValue + FirstValue + int.Parse(lines[i])) {
                increaseAmount++;
            }

            lastSum = SecondValue + FirstValue + int.Parse(lines[i]);

            SecondValue = FirstValue;
            FirstValue = int.Parse(lines[i]);
        }

        Debug.Log(increaseAmount);

        System.TimeSpan thiss = System.DateTime.Now - time;

        Debug.Log(thiss.TotalMilliseconds);
    }
}
