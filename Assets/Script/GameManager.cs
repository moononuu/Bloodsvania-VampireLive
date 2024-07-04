using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score;

    [SerializeField] TextMeshProUGUI scoreText;

    private void Start()
    {
        Instance = this;
    }

    public void AddScore(int scorePlus)
    {
        score = score + scorePlus;

        Debug.Log(score);
        scoreText.text = score.ToString();
    }
}
