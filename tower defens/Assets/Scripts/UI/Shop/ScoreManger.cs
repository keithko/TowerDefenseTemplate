using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManger : MonoBehaviour
{
    [SerializeField]int Score = 0;
    [SerializeField] TMP_Text ScoreText;
    [SerializeField] int tower;
    [SerializeField] int rent = 8;
    private bool buy = false;
    // Start is called before the first frame update
    void Start()
    {
        tower = 10;
        Enemy.Ondied += AddScore;
        UpdateScoreText();
    }

    private void Update()
    {
        UpdateScoreText();
        kopen();
    }
    void UpdateScoreText()
    {
        ScoreText.text = "$" + Score;
    }

    public void kopen()
    {
        if (buy)
        {
            TowerGekocht();  
        }
    }
    // Update is called once per frame
    public void AddScore(int startHP)
    {
       this.Score+= startHP;
    }
    void TowerGekocht()
    {
        
    }
}
