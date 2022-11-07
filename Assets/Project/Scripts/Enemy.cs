using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Player player;

<<<<<<< Updated upstream
    ///VARIABLES
    public int enemyATK, enemyHP;

=======
    //VARIABLES
    public int enemyATK, enemyHP;


>>>>>>> Stashed changes
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
