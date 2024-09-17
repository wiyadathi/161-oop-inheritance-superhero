using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    IronMan ironman = new IronMan("Tony Stark", 100, "Red");
    CaptainAmerica captainAmeriaca = new CaptainAmerica("Steve Rogers", 100, "Bue");
    int round = 0;

    void Start()
    {
        ironman.Name = "";

        Debug.Log($"IronMan Name is : {ironman.Name} Hp is : {ironman.Hp} SuitColor is : {ironman.SuitColor}");

        Debug.Log($"CaptainAmeriaca Name is : {captainAmeriaca.Name} Hp is : {captainAmeriaca.Hp} SuitColor is : {captainAmeriaca.SuitColor}");
    }

    private void Update()
    {
        if (ironman.IsDead() || captainAmeriaca.IsDead())
        {
            return;
        }

        Debug.Log($"Round {round + 1}");

        // สุ่มค่าความเสียหายระหว่าง 1 ถึง 20 (ironman)
        int rand = Random.Range(10, 21);

        ironman.ShootLaser();
        // CaptainAmerica รับความเสียหายจาก IronMan
        captainAmeriaca.TakeDamage(rand);

        //สุ่มค่าความเสียหายระหว่าง 1 ถึง 20 (Captain)
        int rand2 = Random.Range(10, 21);

        captainAmeriaca.ThrowShield();
        // IronMan รับความเสียหายจาก CaptainAmerica
        ironman.TakeDamage(rand2);

        // แสดงสถานะ HP หลังแต่ละรอบ
        Debug.Log($"After round {round++}: IronMan HP = {ironman.Hp}, CaptainAmerica HP = {captainAmeriaca.Hp}");
    }
}