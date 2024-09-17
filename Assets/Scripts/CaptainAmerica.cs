using UnityEngine;

public class CaptainAmerica : SuperHero
{
    public void LeapAndJump()
    {
        Debug.Log($"{_name} is Jumping");
    }

    public void ThrowShield()
    {
        Debug.Log($"{_name} is ThrowShield");
    }
}