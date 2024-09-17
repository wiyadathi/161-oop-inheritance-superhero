using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero : MonoBehaviour
{
    // Attributes
    protected string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value == null || value == "")
            {
                value = "N/A";
            }

            _name = value;
        }
    }

    protected int hp;
    public int Hp { get { return hp; } private set { hp = value; } }

    public string SuitColor { get; set; }

    private float armorStrength;

    public void UpdateArmorStrength(float strength)
    {
        armorStrength += strength;
        Debug.Log($" {_name} update their strngeth to :{armorStrength}");
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log($"{_name} took {damage} damage! Remaining HP: {hp}");

        if (IsDead())
        {
            Debug.Log($"{_name} is dead!");
        }
    }

    public bool IsDead()
    {
        return hp <= 0;
    }
}