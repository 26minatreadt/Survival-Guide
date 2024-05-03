using System.collections;
using System.Collections.Generic
using UnityEngine;

public class Collectable : MonoBehavior 
{

     private void OnTriggerEnter(Collider other)
     {
        if (other.tag == "player")
        {
          Destroy(this.gameobject);
        }
     }
    
}