
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    
    // Start is called before the first frame update
    private void Start()
    {
        Div(5,4);
        Sum(5,4);
        Prod(5,4);
    }
    float Sum(float a, float b)
    {
        Debug.Log(a + b);
        return a + b;
    }
    float Prod(float a, float b)
    {
        Debug.Log(a * b);
        return a*b;
    }
    float Div(float a, float b)
    {
        if (b <= 0)
        {
            Debug.Log("error");
            return 0;
        }
        Debug.Log(a/b);
        return a / b;
        
    }
    
}
