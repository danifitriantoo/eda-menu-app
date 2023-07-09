using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject Maps,Pause,Inventory;

    public int isActive = 0;

    public void inGamePanelControl() 
    {
        if (Input.GetKey(KeyCode.Escape)) { pauseGame(isActive == 0? true : false); }
        if (Input.GetKey(KeyCode.M)) { showMaps(isActive == 0? true : false); }
        if (Input.GetKey(KeyCode.I)) { openInventory(isActive == 0? true : false); }
    }

    public void showMaps(bool key)
    {
        Maps.gameObject.SetActive(key);
        isActive =1;
    }

    public void pauseGame(bool key)
    {
        Pause.gameObject.SetActive(key);
        isActive =1;
    }

    public void openInventory(bool key)
    {
        Inventory.gameObject.SetActive(false);
        isActive =1;
    }
}
