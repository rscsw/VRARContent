using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemainTimer : MonoBehaviour
{
    public float gameTime = 30.0f;
    private TextMeshProUGUI timeText;
    float currentTime;

    void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
        currentTime = gameTime;
        Debug.Log(IsCountingDown());
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if(currentTime <= 0.0f)
        {
            currentTime = 0.0f;
            Debug.Log(IsCountingDown());
        }

        timeText.text = "남은 시간 : " + currentTime.ToString("N2") + "초";
    }

    public bool IsCountingDown()
    {
        return currentTime > 0.0f;
    }
}
