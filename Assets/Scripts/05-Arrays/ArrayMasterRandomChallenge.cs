using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMasterRandomChallenge : MonoBehaviour
{
    [SerializeField] private string[] names;
    [SerializeField] private int[] ages;
    [SerializeField] private string[] cars;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (names.Length > 0)
            {
                int randomIndex = Random.Range(0, names.Length); //0 based indexing exclusive
                string selectedKid = names[randomIndex];
                string selectedKidsAge = ages.Length > randomIndex ? ages[randomIndex].ToString() : "Unavailable";
                string selectedKidsFavoriteCar = cars.Length > randomIndex ? cars[randomIndex] : "Unavailable";
                Debug.Log($"{selectedKid} is {selectedKidsAge} and their favorite car is {selectedKidsFavoriteCar}");
            }
            else
            {
                Debug.Log("There are no kids in the queue");
            }
        }
    }
}
