using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOfGameObject : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    // Start is called before the first frame update
    void Start()
    {
        if (_gameObject == null)
        {
            Debug.LogError("Cube is NULL in ChangeColorOfGameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            ChangeColor(_gameObject, randomColor);
        }
    }

    private void ChangeColor(GameObject objectToColor, Color color)
    {
        Renderer gameObjectRenderer = objectToColor.GetComponent<Renderer>();
        if (gameObjectRenderer != null)
        {
            gameObjectRenderer.material.color = color;
        }
    }
}
