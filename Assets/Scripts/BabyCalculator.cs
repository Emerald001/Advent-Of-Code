using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BabyCalculator : MonoBehaviour
{
    public int n = 23; 

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            float num = Factorial(364) / (Factorial(365 - n) * Mathf.Pow(365, (n - 1)));

            Debug.Log(num);
        }
    }

    float Factorial(int num) {
        int result = 1;
        for (int i = num; i > 0; i--)
            result *= i;
        return result;
    }
}