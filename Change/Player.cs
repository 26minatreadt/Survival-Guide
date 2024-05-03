using System.collections;
using System.Collections.Generic
using UnityEngine;

public class player : MonoBehavior 
{
  public Vector3 startPosition;

  void start()
  {
    transform.position = startPosition;
  }
}