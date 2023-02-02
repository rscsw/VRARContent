using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    public int Points { get; private set; }

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void AddScore(int addPoint)
    {
        Points += addPoint;
        scoreText.text = "점수 : " + Points.ToString() + "점";
    }
}
