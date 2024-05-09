using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int id;
    public string name;
    public static int connectionCount;
    public Player()
    {
        connectionCount++;
    } 
}

public class Test : MonoBehaviour
{
    private void Start()
    {
        Player p1 = new Player();
        Player p2 = new Player();
        Player p3 = new Player();

        Player.connectionCount;
    }
}