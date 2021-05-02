using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimatePrintOuts : MonoBehaviour
{   
    void Start()
    {
        for (int i = 0; i <= 30; i++)
        {
            bool isEven = i % 2 == 0;
            if (i <= 10)
            {
                Debug.Log($"i is {i}");
            } else if (i <= 20 && isEven)
            {
                Debug.Log($"i is {i}");
            } else if (i > 20 && i <= 30 && !isEven)
            {
                Debug.Log($"i is {i}");
            }
            
        }
    }
}
