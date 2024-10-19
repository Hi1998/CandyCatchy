using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score = 0;

    int lives = 3;

    bool gameOver = false;

    /// <summary>
    /// Score Text for displaying the updated score value
    /// </summary>
    public TMP_Text scoreText;

    /// <summary>
    /// Lives Holder is use to display the Current life
    /// </summary>
    public GameObject LivesHolder;

    /// <summary>
    /// GameOver Panel is use to store the reference of the Game Over panel window when my all lives is used.
    /// </summary>
    public GameObject GameOverPanel;

    public static GameManager instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// This method is used for incrementing the score whwenever our player eats candies
    /// </summary>
    public void IncrementScore()
    {
        if(!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
        }
        // Debug.LogError("Score : " + score);
    }


    /// <summary>
    /// Whenever player moisses the candies Lives will decreases
    /// </summary>
    public void DecreaseLives()
    {
        if(lives > 0)
        {
            lives--;
            // Update the current life accccording to the candies missed by player.
            LivesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }
        if(lives <= 0)
        {
            gameOver = true;

            GameOver();
        }
    }

    /// <summary>
    /// When all lives are finished then it will show game is over.
    /// </summary>
    public void GameOver()
    {
        CandySpawner.instance.StopSpawiningCanides();
        GameObject.Find("Player").GetComponent<PlayerController>().isMove = false;
        GameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public int GetMinDistance(int[] nums, int target, int start) {
        int minDist = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == target)
            {
                minDist = Math.Abs(i - start);
                break;
            }
        }
        return minDist;
    }
}