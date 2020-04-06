using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public Text scoreText;
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("ScoreZone"))
        {
            score = score + 1;
            setScoreText();
        }
    }
    private void Update()
    {
        score += 1 * Time.deltaTime;
        scoreText.text = score.ToString("0");
    }


    void setScoreText()
    {
        scoreText.text = score.ToString();
    }

    public void resetScore()
    {
        score = 0;
        setScoreText();
    }
}
