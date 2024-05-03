using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customerdatabase : MonoBehaviour
{
    public Customer jonathan;
    public Customer jannet;
    public Customer jessica;

    private void Start()
    {
        jonathan = new Customer("Jonathan", "Weinberger", 26, "M", "Software Engineer");
        jannet = new Customer("Jannet", "", 55, "F", "Instructor");
        jessica = new Customer("Jessica", "Lang", 23, "F", "Scientist");
    }
}
