using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private float MaxHealt = 10f;
    private float CurrentHealt;
    public TMP_Text HPText;
    public GameObject losing;
    // Start is called before the first frame update
    void Start()
    {
        losing.SetActive(false);
        CurrentHealt = MaxHealt;
        Healttxt();
    }

    private void Update()
    {
        Healttxt();
        lose();
    }

    void Healttxt()
    {
        HPText.text = CurrentHealt.ToString();
    }
            // Update is called once per frame

    void lose()
    {
        if(CurrentHealt<= 0)
        {
            losing.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            losing.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void TakeDamage(int damage)
    {
        CurrentHealt -= damage;
    }
}
