using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Player player;

    //VARIABLES
    public int enemyATK, enemyHP;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ATK
        player.playerHP = enemyATK - player.playerDEF;
    }
}
