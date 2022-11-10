using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject battleGameObject;
    public GameObject currentRoom;
    public Player player;
    private void Awake()
    {
        player = FindObjectOfType<Player>();
        instance = this;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void StartCombat() 
    {
        battleGameObject.SetActive(true);
        currentRoom.SetActive(false);
        SceneManager.LoadScene("Battle Scene");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Battle Scene"));
    }

    public void EndCombat()
    {
        SceneManager.UnloadScene("Battle Scene");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("LootRoom"));
    }
}
