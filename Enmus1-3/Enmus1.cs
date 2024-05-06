using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enmus1 : MonoBehaviour
{
    public enum LevelSelector
    {
        Easy,
        Normal,
        Hard,
        Expert,
    }

    public LevelSelector currentLevel;

    private void Start()
    {

        switch(currentLevel)
        {
            case LevelSelector.Easy:

                break;
            case LevelSelector.Normal:

                break;
        }
    }
}