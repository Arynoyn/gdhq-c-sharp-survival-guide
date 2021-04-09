using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorManager : MonoBehaviour
{
    public GameObject _cube;

    private MeshRenderer _meshRenderer;

    [SerializeField] private int _score = 0;
    private bool _hasHadColorChanged = false;
    private bool _isMeshRendererNotNull;

    // Start is called before the first frame update
    void Start()
    {
        
        if (_cube != null)
        {
            _meshRenderer = _cube.GetComponent<MeshRenderer>();
            _isMeshRendererNotNull = _meshRenderer != null;
            if (_isMeshRendererNotNull)
            {
                _meshRenderer.material.color = Color.red;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _score++;
        }

        if (_isMeshRendererNotNull &&_score > 50 && !_hasHadColorChanged)
        {
            _meshRenderer.material.color = Color.green;
            _hasHadColorChanged = true;
        }
    }
}
