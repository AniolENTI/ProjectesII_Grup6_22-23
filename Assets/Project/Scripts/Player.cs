using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Enemy enemy;

<<<<<<< Updated upstream
    ///VARIABLES
    public int playerHP, playerDEF, playerATK, affinity;
=======
    //VARIABLES
    public int playerATK, playerHP, playerDEF, affinity;

>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ATK
        enemy.enemyHP = (playerATK - playerDEF) * affinity;

<<<<<<< Updated upstream
        //Heal
=======
        //HEAL
>>>>>>> Stashed changes
        playerHP++;
    }
}
