using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeArrayColorChange : MonoBehaviour
{
    public GameObject[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.R))
        {
            foreach (var cube in cubes)
            {
                cube.GetComponent<Renderer>().material.color = Color.red;
            }
        } else if (Input.GetKeyDown(KeyCode.B))
        {
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }
}
