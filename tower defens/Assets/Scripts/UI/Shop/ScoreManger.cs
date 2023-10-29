using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManger : MonoBehaviour
{
    [SerializeField]int Score = 0;
    [SerializeField] TMP_Text MoneyText;
    [SerializeField] TMP_Text TowerKostText;
    [SerializeField] int tower;
    [SerializeField] int rent = 8;
    private bool buy = false;
    // Start is called before the first frame update
    void Start()
    {

        Enemy.Ondied += AddScore;
        UpdateMoneyText();
        UpdateTowerKostText();
    }

    private void Update()
    {
        UpdateMoneyText();
        UpdateTowerKostText();
        kopen();
    }
    void UpdateMoneyText()
    {
        MoneyText.text = "$" + Score;
    }

    private void UpdateTowerKostText()
    {
        TowerKostText.text = "$" + tower;
    }

    public void kopen()
    {
        if (buy)
        {
            TowerGekocht();
            Debug.Log("toren gekocht de rente gaan omhoog");
        }
    }
    // Update is called once per frame
    public void AddScore(int startHP)
    {
       this.Score+= startHP;
    }
    void TowerGekocht()
    {
        tower = tower + rent;
        Score -= tower;
    }
}
