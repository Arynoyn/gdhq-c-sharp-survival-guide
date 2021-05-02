using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player02 : MonoBehaviour
{
    [SerializeField] private int _points;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _points += 10;
        }

        if (_points >= 50)
        {
            Debug.Log("You Are Awesome!");
        }
    }
}