using System.collections;
using System.Collections.Generic
using UnityEngine;

public class Spawncube : MonoBehavior 
{
     [SerlalizedField]
     private GameObject cubePrefab;

      void update ()
      {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          Instantiate(cubePrefab, Vector3.Zero, quaternion.Luler(0, 35, 0));
        }
      }
}