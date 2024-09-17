using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero
{
    // Attributes
    protected string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value == null || value == "")
            {
                value = "N/A";
            }

            name = value;
        }
    }

    protected int hp;
    public int Hp { get { return hp; } private set { hp = value; } }

    public string SuitColor { get; set; }

    private float armorStrength;

    // Constructor
    public SuperHero(string newName, int newHp, string newSuitColor)
    {
        name = newName;
        hp = newHp;
        SuitColor = newSuitColor;
        armorStrength = 10;
    }

    public void UpdateArmorStrength(float strength)
    {
        armorStrength += strength;
        Debug.Log($" {name} update their strngeth to :{armorStrength}");
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log($"{name} took {damage} damage! Remaining HP: {hp}");

        if (IsDead())
        {
            Debug.Log($"{name} is dead!");
        }
    }

    public bool IsDead()
    {
        return hp <= 0;
    }
}