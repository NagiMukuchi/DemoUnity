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
    public EnemySpawner spawner; // Tham chiếu đến EnemySpawner
    public GameObject Boss; // Tham chiếu đến Boss

    public int living;

    private bool bossSpawned = false; // Kiểm tra nếu boss đã được sinh ra

    private void Start()
    {
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);
        playerHealth.onDead += OnGameOver;
        Boss.SetActive(false);
    }

    private void Update()
    {
        living = EnemyHealth.LivingEnemyCount;

        // Kiểm tra nếu tất cả enemy đã sinh ra và không còn enemy sống
        if (spawner.CreateAllEnemy && EnemyHealth.LivingEnemyCount <= 1 && !bossSpawned)
        {
            SpawnBoss(); // Sinh boss nếu chưa sinh
        }

        // Kiểm tra nếu boss đã chết và không còn enemy sống
        if (bossSpawned && !Boss.activeInHierarchy)
        {
            OnGameWin(); // Gọi chiến thắng khi boss đã chết
        }
    }

    private void SpawnBoss()
    {
        if (Boss != null)
        {
            Boss.SetActive(true); // Kích hoạt boss
            bossSpawned = true; // Đánh dấu boss đã sinh ra
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
