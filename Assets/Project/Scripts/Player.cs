using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Enemy enemy;
    
    //VARIABLES
    public int playerATK, playerHP, playerDEF, affinity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ATK
        enemy.enemyHP = (playerATK - playerDEF) * affinity;

        //HEAL
        playerHP++;
    }
}