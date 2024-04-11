using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField]
    public int _points; 
    private bool _hasMessageBeenSent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _points += 10;
        }
        if (_points >= 50 && _hasMessageBeenSent == false)
        {
            Debug.Log("You are awesome!");
            _hasMessageBeenSent = true;
        }
    }
}