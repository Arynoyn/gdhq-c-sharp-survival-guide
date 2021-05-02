using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector : MonoBehaviour
{
    [SerializeField, Range(0,2)] private int WeaponID;
    

    // Update is called once per frame
    void Update()
    {
        switch (WeaponID)
        {
            case 0:
                Debug.Log("You have selected a gun.");
                break;
            case 1:
                Debug.Log("You have selected a knife.");
                break;
            case 2:
                Debug.Log("You have selected a machine gun.");
                break;
        }
    }
}
