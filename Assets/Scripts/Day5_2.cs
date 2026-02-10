using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//one star, A little Faster
public class Day5_2 : MonoBehaviour {

    public TextAsset txt;

    //128 rows (0 to 127)
    //8 columns (0 to 7)

    int highest = 0;

    void Start() {
        System.DateTime time = System.DateTime.Now;

        var lines = txt.text.Split('\n');

        for (int i = 0; i < lines.Length; i++) {
            var row = 0;
            var column = 0;
            var rowMin = 0;
            var rowMax = 128;
            var colMin = 0;
            var colMax = 8;

            //define row + column
            for (int j = 0; j < 10; j++) {
                if (j == 6) {
                    if (lines[i].ToCharArray()[j] == 'F') {
                        row = rowMin;
                    }
                    else if (lines[i].ToCharArray()[j] == 'B') {
                        row = rowMax - 1;
                    }
                    continue;
                } else if (j == 9) {
                    if (lines[i].ToCharArray()[j] == 'L') {
                        column = colMin;
                    }
                    else if (lines[i].ToCharArray()[j] == 'R') {
                        column = colMax - 1;
                    }
                    continue;
                }

                if (j < 6) {
                    if (lines[i].ToCharArray()[j] == 'F') {
                        rowMax -= ((rowMax - rowMin) / 2);
                    }
                    else if (lines[i].ToCharArray()[j] == 'B') {
                        rowMin += (rowMax - rowMin) / 2;
                    }
                } else {
                    if (lines[i].ToCharArray()[j] == 'L') {
                        colMax -= ((colMax - colMin) / 2);
                    }
                    else if (lines[i].ToCharArray()[j] == 'R') {
                        colMin += (colMax - colMin) / 2;
                    }
                }
            }

            //times eachother plus check
            if (row * 8 + column > highest) {
                highest = row * 8 + column;
            }
        }

        Debug.Log(highest);

        System.TimeSpan thiss = System.DateTime.Now - time;
        Debug.Log(thiss.TotalMilliseconds);
    }
}
