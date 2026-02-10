using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;

//two stars
public class Day3 : MonoBehaviour
{
    public TextAsset txt;
    int lineLength = 31;
    char treechar = '#';

    List<int> Answers = new List<int>();

    void Start() {
        System.DateTime time = System.DateTime.Now;

        var lines = txt.text.Split('\n');

        for (int j = 1; j <= 7; j += 2) {
            var currentPosReuse = 0;
            var treesFound1 = 0;
            for (int i = 0; i < lines.Length; i++) {
                if (lines[i].TrimEnd().ToCharArray()[currentPosReuse] == treechar)
                    treesFound1++;

                currentPosReuse += j;

                if(currentPosReuse >= lineLength) {
                    currentPosReuse -= lineLength;
                }
            }
            Answers.Add(treesFound1);
        }

        var currentPos = 0;
        int treesFound2 = 0;
        for (int i = 0; i < lines.Length; i += 2) {
            if (lines[i].TrimEnd().ToCharArray()[currentPos] == treechar)
                treesFound2++;

            currentPos++;

            if (currentPos >= lineLength) {
                currentPos -= lineLength;
            }
        }
        Answers.Add(treesFound2);

        BigInteger final = 0;
        for (int i = 0; i < Answers.Count; i++) {
            if (final == 0)
                final = Answers[i];
            else
                final *= Answers[i];
        }
        Debug.Log(final);

        System.TimeSpan thiss = System.DateTime.Now - time;
        Debug.Log(thiss.TotalMilliseconds);
    }
}