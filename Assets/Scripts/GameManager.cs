using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] CollisionController player;

    [SerializeField] GameObject gameOverUI;

    private void Awake()
    {
        player.OnGameOver += GameOver;        
    }

    private void GameOver()
    {
        player.OnGameOver -= GameOver;
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
