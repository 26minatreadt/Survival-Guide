using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(cube, Color.blue);
        }  
    }
    private void ChangeColor(GameObject obj, Color colorToAssign )
    {
        obj.GetComponent<MeshRenderer>().material.color = colorToAssign;
    }
}
