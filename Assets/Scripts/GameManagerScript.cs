using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject gameOverPanel;
    public Button restartButton;

    private int score;
    private bool isGameOver;

    private void Start()
    {
        PipeScript.onPlayerPassedPipe += AddScore;
        BirdScript.onHit += GameOver;
    }

    // Update is called once per frame
    private void Update() { }

    private void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    void GameOver()
    {
        if (isGameOver)
            return;

        if (gameOverPanel != null)
        {
            gameOverPanel?.SetActive(true);
        }
        isGameOver = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
