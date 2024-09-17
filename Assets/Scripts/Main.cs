using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
   
    void Start()
    {
        #region Show stat
        IronMan ironman = new IronMan("Tony Stark", 100, "Red");
        Debug.Log($"IronMan Name is : {ironman.Name} Hp is : {ironman.Hp} SuitColor is : {ironman.SuitColor}");

     

        CaptainAmerica captainAmeriaca = new CaptainAmerica("Steve Rogers" ,100 ,"Bue");
        Debug.Log($"CaptainAmeriaca Name is : {captainAmeriaca.Name} Hp is : {captainAmeriaca.Hp} SuitColor is : {captainAmeriaca.SuitColor}");
        #endregion


        #region Loop ��� 5 �ͺ
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"Round {i + 1}");

            // ������Ҥ���������������ҧ 1 �֧ 20 (ironman)
            int rand = Random.Range(10, 21);

            ironman.ShootLaser();
            // CaptainAmerica �Ѻ����������¨ҡ IronMan
            captainAmeriaca.TakeDamage(rand);

            //������Ҥ���������������ҧ 1 �֧ 20 (Captain)
            int rand2 = Random.Range(10, 21);

            captainAmeriaca.ThrowShield();
            // IronMan �Ѻ����������¨ҡ CaptainAmerica
            ironman.TakeDamage(rand2);

            // �ʴ�ʶҹ� HP ��ѧ�����ͺ
            Debug.Log($"After round {i + 1}: IronMan HP = {ironman.Hp}, CaptainAmerica HP = {captainAmeriaca.Hp}");

        }
        #endregion
    }
}