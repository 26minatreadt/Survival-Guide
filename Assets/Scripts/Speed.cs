using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public int speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            speed -= 5;
        }
        if (speed> 20)
        {
            Debug.Log("Slow Down!");
        }
        else if (speed == 0)
        {
            Debug.Log("Speed up!");
        }
    }
}
