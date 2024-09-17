using UnityEngine;

class CaptainAmerica : SuperHero
{
    public CaptainAmerica(string newName, int newHp, string newSuitColor)
        : base(newName, newHp, newSuitColor)
    {
    }

    public void LeapAndJump()
    {
        Debug.Log($"{name} is Jumping");
    }

    public void ThrowShield()
    {
        Debug.Log($"{name} is ThrowShield");
    }
}