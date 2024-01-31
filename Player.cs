using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //������� �������� ������
    public int health = 10;
    //������������ �������� ������
    public int maxHealth = 10;

    public int coins;
    
    public void TakeDamage(int pessF){
        health -= pessF;
    }
}
