using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerPosition : MonoBehaviour
{
    [SerializeField] private Vector3[] _positions = new Vector3[5];
    [SerializeField] private GameObject _player;
    
    void Start()
    {
        InitializePositionArray();
        int index = GetRandomIndex();
        SetPlayerPosition(index);
    }

    private void InitializePositionArray()
    {
        for (int i = 0; i < _positions.Length; i++)
        {
            _positions[i] = new Vector3(GetRandomCoordinateValue(), GetRandomCoordinateValue(), GetRandomCoordinateValue());
        }
    }

    private float GetRandomCoordinateValue()
    {
        return Random.value * 100;
    }

    private void SetPlayerPosition(int index)
    {
        _player.transform.position = _positions[index];
    }

    private int GetRandomIndex()
    {
        return Random.Range(0, _positions.Length);
    }
}
