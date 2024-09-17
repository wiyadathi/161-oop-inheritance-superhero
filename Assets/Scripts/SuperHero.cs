using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero
{
    // Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStrength;

    // Constructor
    public SuperHero(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;
        armorStrength = 10;
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

        if (IsDead())
        {
            Debug.Log($"{Name} is dead!");
        }
    }

    public bool IsDead()
    {
        return Hp <= 0;
    }
}