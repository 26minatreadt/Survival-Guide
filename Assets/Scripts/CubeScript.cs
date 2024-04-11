using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public GameObject cube;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && score <= 50)
        {
            score += 25;
        }
        if (score > 50)
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}