using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enmus2 : MonoBehaviour
{
    public enum Enemystate
    {
        Partroling,
        Attacking,
        Chasing,
        Death
    }

    public Enemystate currentState;
    void Start()
    {
        currentStateState = Enemystate.Patroling;
    }
    void Update()
    {
        switch (currentState)
        {
            case Enemystate.Partroling:
                Debug.Log("Patrolling");
                if (TIme.time > 5)
                {
                    currentState = Enemystate.Chasing;
                }
                break;
            case Enemystate.Attacking:
                Debug.Log("Attacking");
                break;
            case Enemystate.Chasing:
                Debug.Log("Chasing");
                break;
             case Enemystate.Death:
                Debug.Log("Death");
                break;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            currentState = Enemystate.Attacking;
        }
    }
}