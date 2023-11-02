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
    BuiltManager builtManager;
    // Start is called before the first frame update
    void Start()
    {
        builtManager = BuiltManager.instance;
        Enemy.Ondied += AddScore;
        UpdateMoneyText();
        UpdateTowerKostText();
    }

    private void Update()
    {
        UpdateMoneyText();
        UpdateTowerKostText();
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
            TowerGekocht();
    }
    // Update is called once per frame
    public void AddScore(int startHP)
    {
       this.Score+= startHP;
    }
    void TowerGekocht()
    {
        if(Score >= tower)
        {
            Score -= tower;
            tower = tower + rent;
            Debug.Log("toren groen gekocht");
            builtManager.SetTowerToBuild(builtManager.standardTowerPrefab);
        }
    }
}
