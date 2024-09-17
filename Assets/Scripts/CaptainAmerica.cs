using UnityEngine;

class CaptainAmerica
{
   public string Name;
   public int Hp;
   public string SuitColor;
   private float armorStrength;


    public CaptainAmerica(string newName ,int newHp ,string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;
        armorStrength = 10;
    }

    public void LeapAndJump()
    {
        Debug.Log($"{Name} is Jumping");
    }

    public void ThrowShield()
    {
        Debug.Log($"{Name} is ThrowShield");
    }

    public void UpdateStrngth(float strngth)
    {
        armorStrength += strngth;
        Debug.Log($"{Name} update their strngeth to {armorStrength}");
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

