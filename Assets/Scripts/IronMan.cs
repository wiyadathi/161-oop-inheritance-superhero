using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan : SuperHero
{
    public void Fly()
    {
        Debug.Log($"{_name} is Fly");
    }

    public void ShootLaser()
    {
        Debug.Log($"{_name} is shooting lsers");
    }
}