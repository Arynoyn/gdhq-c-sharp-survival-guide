using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //every item has a name
    public string name = "Item";
    //every item has a description
    public string description = "Item Description";
    //every item has an image icon
    public Sprite imageIcon;
    //every item has an attack strength
    public int attackStrength = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Item Name: {name}");
        Debug.Log($"Item Description: {description}");
        Debug.Log($"Item Attack Strength: {attackStrength}");
        
        if (imageIcon == null)
        {
            Debug.LogError("Image Icon missing on Item");
        }
        else
        {
            Debug.Log($"Image Icon Name: {imageIcon.name}");
        }
    }
}