using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Text activeEnemiesText;

    public void UpdateEnemyCount()
    {
        activeEnemies.text = "Active Enemies: " + SpawnManager.enemyCount;
    }
}