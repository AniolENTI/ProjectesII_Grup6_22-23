using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageEvents : MonoBehaviour
{
    public GameObject combatPlaceholder;
    public GameObject chestPlaceholder;
    // Start is called before the first frame update
    void Start()
    {
        combatPlaceholder.SetActive(false);
        chestPlaceholder.SetActive(false);
    }

   public void ActivateCombatPlaceholder()
    {
        combatPlaceholder.SetActive(true);
    }
    public void ActivateChestPlaceholder()
    {
        chestPlaceholder.SetActive(true);
    }
    public void DisableCombatButton()
    {
        combatPlaceholder.SetActive(false);
    }
    public void DisableChestButton()
    {
        chestPlaceholder.SetActive(false);
    }
}
