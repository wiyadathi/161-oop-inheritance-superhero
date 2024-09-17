using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class IronMan : SuperHero
{
    public IronMan(string newName, int newHp, string newSuitColor)
        : base(newName, newHp, newSuitColor)
    {

    }

    public void Fly()
    {
        Debug.Log($"{Name} is Fly");
    }

    public void ShootLaser()
    {
        Debug.Log($"{Name} is shooting lsers");
    }
}