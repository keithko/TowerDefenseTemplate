using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winkel : MonoBehaviour
{
    public GameObject winkel;
    private bool ShopOpen = false;
    // Start is called before the first frame update
    void Start()
    {
       winkel.SetActive(false);
    }

    // Update is called once per frame
    public void TowerShop()
    {
            if (ShopOpen)
            {
            Closed();
            Debug.Log("winkel digt");
            }

            else
            {
            Open();
            Debug.Log("winkel open");
            }
    }
    void Open()
    {
        winkel.SetActive(true);
        ShopOpen= true;
    }

    void Closed()
    {
        winkel.SetActive(false);
        ShopOpen= false;
    }
}
