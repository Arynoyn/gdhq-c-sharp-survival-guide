using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    [SerializeField] private int _speed = 0;
    [SerializeField] private bool _hasShownSpeedUpMessage;
    [SerializeField] private bool _hasShownSlowDownMessage;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            _speed += 10;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
             _speed = _speed - 10 < 0 ? 0 : _speed - 10;
        }

        if (_speed > 20 && !_hasShownSlowDownMessage)
        {
            Debug.Log("Slow Down!");
            _hasShownSlowDownMessage = true;
        } else if (_hasShownSlowDownMessage && _speed <= 20)
        {
            _hasShownSlowDownMessage = false;
        } 
        
        if (_speed == 0 && !_hasShownSpeedUpMessage)
        {
            Debug.Log("Speed Up!");
            _hasShownSpeedUpMessage = true;
        } else if (_hasShownSpeedUpMessage && _speed != 0)
        {
            _hasShownSpeedUpMessage = false;
        }
    }
}
