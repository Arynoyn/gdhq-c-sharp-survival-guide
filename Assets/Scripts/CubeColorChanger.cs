using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorChanger : MonoBehaviour
{
    public GameObject _cube;
    [SerializeField] private int _cubeColorChoice = 0;
    private Color _cubeColor;
    private Renderer _renderer;
    private bool _isCubeNull;
    private bool _isRendererNull;

    // Update is called once per frame
    private void Start()
    {
        if (_cube == null)
        {
            Debug.LogError("Cube is missing!");
            _isCubeNull = true;
        }
        else
        {
            _renderer = _cube.GetComponent<Renderer>();
            if (_renderer == null)
            {
                Debug.LogError("Renderer is missing!");
                _isRendererNull = true;
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _cubeColorChoice = 0;
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _cubeColorChoice = 1;
        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _cubeColorChoice = 2;
        } else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _cubeColorChoice = 3;
        }

        switch (_cubeColorChoice)
        {
            case 0:
                _cubeColor = Color.blue;
                break;
            case 1:
                _cubeColor = Color.red;
                break;
            case 2:
                _cubeColor = Color.green;
                break;
            case 3:
                _cubeColor = Color.black;
                break;
            default:
                break;
        }

        if (!_isCubeNull && !_isRendererNull && _renderer.material.color != _cubeColor)
        {
            _renderer.material.color = _cubeColor;
        }
    }
}
