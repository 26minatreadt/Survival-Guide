using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovemont : MonoBehaviour
{
    [SerializeField]
    private float _horizontalInput;
    [SerializeField]
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(_horizontalInput, 0, 0) *_speed * Time.deltaTime);
    }   
}