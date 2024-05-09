using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityHelper : MonoBehaviour
{
    public static void CreateObject()
    {
        //create a new primitive Cube
        GameObject.CreatePrimitive(PrimiteType.Cube);
    }

    public static void SetPositiontoZero(GameObject obj)
    {
        //change position of obj
        obj.transform.position = Vector3.zero;
    }
}
