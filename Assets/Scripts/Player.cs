using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _points;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _points += 10;
        }
    }
}
