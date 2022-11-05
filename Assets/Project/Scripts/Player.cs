using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    ///VARIABLES
    //initialize this variables
    public int playerHP, playerDEF, playerATK, affinity;
    public int enemyATK, enemyHP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ATK
        enemyHP = (playerATK - playerDEF) * affinity;

        //Heal
        playerHP++;
    }
}
