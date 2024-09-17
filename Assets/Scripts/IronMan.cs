using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class IronMan
{
    // Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStrength;
    

    // Constructor
    public IronMan(string newName , int newHp , string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;
        armorStrength = 10;
    }

    public void Fly()
    {
        Debug.Log($"{Name} is Fly");
    }

    public void ShootLaser()
    {
        Debug.Log($"{Name} is shooting lsers");
    }

    public void UpdateArmorStrength(float strength)
    {
        armorStrength += strength;
        Debug.Log($" {Name} update their strngeth to :{armorStrength}");
    }

    public void TakeDamage(int damage)
    {
      
        Hp -= damage;
        Debug.Log($"{Name} took {damage} damage! Remaining HP: {Hp}");

        IsDead();

    }

    public bool IsDead()
    {
        if (Hp <= 0)
        {
            Debug.Log($"{Name} is Die!!");
        }
           
        return true;
    }

}