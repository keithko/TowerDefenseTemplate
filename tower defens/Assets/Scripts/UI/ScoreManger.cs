using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManger : MonoBehaviour
{
    [SerializeField]int Score = 0;
    [SerializeField] TMP_Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }
    void UpdateScoreText()
    {
        ScoreText.text = "score" + Score;
    }

    // Update is called once per frame
    public void AddScore()
    {
        this.Score+= Score;
    }
}
