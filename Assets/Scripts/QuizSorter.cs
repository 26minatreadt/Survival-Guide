using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizSorter : MonoBehaviour
{
    public float quiz1, quiz2, quiz3, quiz4, quiz5;
    public float average;
    // Start is called before the first frame update
    void Start()
    {
        quiz1 = Random.Range(1, 101);
        quiz2 = Random.Range(1, 101);
        quiz3 = Random.Range(1, 101);
        quiz4 = Random.Range(1, 101);
        quiz5 = Random.Range(1, 101);

    float average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;
   
    if (average >= 90)
    {
        Debug.Log("You have an A");
    }
    else if (average >= 80 && average < 90)
    {
        Debug.Log("You have a B");
    }
    else if (average >= 70 && average < 80)
    {
        Debug.Log("You have a C");
    }
    else
    {
        Debug.Log("You have an F");
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}