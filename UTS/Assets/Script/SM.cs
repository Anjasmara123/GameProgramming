using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;
    public bool scoreIncreasing;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
        }

        scoreText.text = "Score : " + Mathf.Round(scoreCount);
        hiScoreText.text = "High Score : " + Mathf.Round(hiScoreCount);
    }
}