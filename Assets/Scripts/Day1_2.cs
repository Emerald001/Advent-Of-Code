using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Worse version, but attempt at faster code
public class Day1_2 : MonoBehaviour {

    public TextAsset txt;
    List<int> numbersFound = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        System.DateTime time = System.DateTime.Now;

        var lines = txt.text.Split('\n');
        var nums = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++) {
            nums[i] = int.Parse(lines[i]);
        }

        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                for (int k = 0; k < nums.Length; k++) {
                    if (nums[i] + nums[j] + nums[k] == 2020) {
                        numbersFound.Add(nums[i] * nums[j] * nums[k]);
                    }
                }
            }
        }

        for (int i = 0; i < numbersFound.Count; i++) {
            Debug.Log(numbersFound[i]);
        }

        System.TimeSpan thiss = System.DateTime.Now - time;

        Debug.Log(thiss.TotalMilliseconds);
    }
}