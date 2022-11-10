using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Player : MonoBehaviour
{
    public StatManager statManager;
    public TextMeshProUGUI stepText;
    public int stepsRemaining;
    Vector2 lastPosition;
    private void Start()
    {
        stepText.text = stepsRemaining + "\nSteps Remaining";
    }

    // Update is called once per frame
    void Update()
    {
        if(stepsRemaining > 0)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                MovePlayer(Vector2.up);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                MovePlayer(Vector2.down);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                MovePlayer(Vector2.right);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                MovePlayer(Vector2.left);
            }
        }
        if(stepsRemaining == 0)
        {
            stepsRemaining = 0;
        }
    }

    void MovePlayer(Vector3 direction)
    {
        stepsRemaining--;
        stepText.text = stepsRemaining + "\nSteps Remaining";
        lastPosition = new Vector2(transform.position.x, transform.position.y);
        transform.position += direction;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Wall"))
        {
            Debug.Log("Jugador ha entrat a la paret");
            transform.position = lastPosition;
            stepsRemaining++;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Enemy"))
        {
            Debug.Log("COMBAT");
            GameController.instance.StartCombat();
        }
        if (collision.CompareTag("Chest"))
        {
            Debug.Log("CHEST");
            statManager.gainEssence(1);
        }
    }
}
