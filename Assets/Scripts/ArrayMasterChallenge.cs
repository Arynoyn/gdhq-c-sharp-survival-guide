using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMasterChallenge : MonoBehaviour
{
    [SerializeField] private string[] names;
    [SerializeField] private int[] ages;
    [SerializeField] private string[] cars;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int lastIndex = names.Length - 1; //0 based indexing
            if (lastIndex >= 0)
            {
                string selectedKid = names[lastIndex];
                string selectedKidsAge = ages.Length > lastIndex ? ages[lastIndex].ToString() : "Unavailable";
                string selectedKidsFavoriteCar = cars.Length > lastIndex ? cars[lastIndex] : "Unavailable";
                Debug.Log($"{selectedKid} is {selectedKidsAge} and their favorite car is {selectedKidsFavoriteCar}");
            }
            else
            {
                Debug.Log("There are no kids in the queue");
            }
        }
    }
}
