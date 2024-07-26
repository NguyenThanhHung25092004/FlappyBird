using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public AudioSource coinSound;
    public bool gameOver = false;

    void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();    
    }
    public void addScore(int plus)
    {
        if (!gameOver)
        {
            playerScore += plus;
            scoreText.text = playerScore.ToString();
            coinSound.Play();
            if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", playerScore);
            }
        } 
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void isGameOver()
    {
        gameOver = true;
        gameOverScreen.SetActive(true);
    }

}
