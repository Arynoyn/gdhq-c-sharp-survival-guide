#region

using System.Collections;
using UnityEngine;

#endregion

public class MaxSpeedLoop : MonoBehaviour
{
    private int _currentSpeed;
    private int _maxSpeed;
    private int _maxSpeedLimit = 120;

    private int _minSpeedLimit = 60;

    // Start is called before the first frame update
    private void Start()
    {
        _maxSpeed = Random.Range(_minSpeedLimit, _maxSpeedLimit + 1);
        StartCoroutine(MaxSpeedRoutine());
    }

    private IEnumerator MaxSpeedRoutine()
    {
        while (true)
        {
            _currentSpeed += 5;
            Debug.Log($"Current Speed: {_currentSpeed}");
            if (_currentSpeed > _maxSpeed)
            {
                Debug.Log($"Max Speed of {_maxSpeed} Exceeded");
                yield break;
            }

            yield return new WaitForSeconds(1.0f);
        }
    }
}