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

    private void Start()
    {
        PipeScript.onPlayerPassedPipe += AddScore;
        BirdScript.onHit += GameOver;

        // why can't i use +- here???
        restartButton.onClick.AddListener(Restart);
    }


    // Update is called once per frame
    private void Update()
    {
    }

    private void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    private void GameOver()
    {
        gameOverPanel?.SetActive(true);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}