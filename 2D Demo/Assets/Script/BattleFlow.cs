using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameWinUI;
    public PlayerHealth playerHealth;
    public GameObject bgMusic;
    public EnemySpawner spawner;

    public int living;

    private void Start()
    {
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);
        playerHealth.onDead += OnGameOver;
    }

    private void Update()
    {
        living = EnemyHealth.LivingEnemyCount;
        if (spawner.CreateAllEnemy && EnemyHealth.LivingEnemyCount <= 0)
        {
            Invoke(nameof(OnGameWin), 1);
        }
    }

    private void OnGameWin()
    {
        if (playerHealth.healthPoint > 0)
        {

            gameWinUI.SetActive(true);
            bgMusic.SetActive(false);
            playerHealth.gameObject.SetActive(false);
        }
    }



    private void OnGameOver()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(false);
    }

    public void ReturnToMainMenu() => SceneManager.LoadScene("MainMenu");
}
