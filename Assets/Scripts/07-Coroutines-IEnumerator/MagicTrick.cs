using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicTrick : MonoBehaviour
{
    [SerializeField] private GameObject _objectToHide;
    private bool _objectIsHidden;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !_objectIsHidden)
        {
            HideObject();
            StartCoroutine(HiddenObjectCooldownRoutine());
        }
    }

    private IEnumerator HiddenObjectCooldownRoutine()
    {
        yield return new WaitForSeconds(5.0f);
        ShowObject();
    }

    private void ShowObject()
    {
        _objectToHide.SetActive(true);
        _objectIsHidden = false;
    }
    
    private void HideObject()
    {
        _objectToHide.SetActive(false);
        _objectIsHidden = true;
    }
}
