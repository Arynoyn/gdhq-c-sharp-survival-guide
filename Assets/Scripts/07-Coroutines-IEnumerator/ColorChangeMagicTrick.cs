using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColorChangeMagicTrick : MonoBehaviour
{
    [SerializeField] private GameObject _objectToChangeColor;
    private Renderer _renderer;
    private bool _isRendererNull;

    void Start()
    {
        
        if (_objectToChangeColor == null)
        {
            Debug.LogError("Object for color change is NULL in ColorChangeMagicTrick");
        }
        else
        {
            _renderer = _objectToChangeColor.GetComponent<Renderer>();
            _isRendererNull = _renderer == null;
            if (_isRendererNull)
            {
                Debug.LogError("Renderer for color change is NULL in ColorChangeMagicTrick");
            }
        }
        
        StartCoroutine(ColorChangeRoutine());
    }
    private IEnumerator ColorChangeRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(3.0f);
            ChangeColor(GetRandomColor());
        }
    }

    private void ChangeColor(Color color)
    {
        if (_isRendererNull) { return; }
        _renderer.material.color = color;
    }

    private Color GetRandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
