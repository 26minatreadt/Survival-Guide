using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDiff : MonoBehaviour
{
    // Start is called before the first frame update
    private int _easy = 0;
    private int _medium = 1;
    private int _hard = 2;
    public int selectedLevel;

    void Start()
    {
        selectedLevel = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        // if (selectedLevel == _easy)
        // {
        //     Debug.Log("You selected easy");
        // }
        // else if (selectedLevel == _medium)
        // {
        //     Debug.Log("You selected medium");
        // }
        // else if (selectedLevel == _hard)
        // {
        //     Debug.Log("You selected hard");
        // }
        // else
        // {
        //     Debug.Log("Invalid Level Selected");
        // }

        switch(selectedLevel)
        {
            case 0: //easy
                Debug.Log("Easy!");
                break;
            case 1: //medium
                Debug.Log("Medium!");
                break;
            case 2: //hard
                Debug.Log("Hard!");
                break;
            default:
                Debug.Log("Invalid Level Selected");
                break;            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            selectedLevel = Random.Range(0, 3);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            selectedLevel = 55;
        }
    }
}