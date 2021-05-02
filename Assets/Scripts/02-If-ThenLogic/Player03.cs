using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player03 : MonoBehaviour
{
    [SerializeField] private int _points;
    private bool hasLoggedMessage;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _points += 10;
        }

        if (_points >= 50 && !hasLoggedMessage)
        {
            Debug.Log("You Are Awesome!");
            hasLoggedMessage = true;
        }
    }
}