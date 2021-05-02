using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayerAliveTest : MonoBehaviour
{
    private bool _playerAlive = true;
    [SerializeField] private int _playerHealth = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _playerAlive)
        {
            int damage = Random.Range(0, 100);
            DamagePlayer(damage);
        }
    }

    private void DamagePlayer(int damage)
    {
        _playerHealth -= damage;
        if (_playerHealth < 1)
        {
            Debug.Log("The player has died!");
            _playerAlive = false;
        }
    }
}
