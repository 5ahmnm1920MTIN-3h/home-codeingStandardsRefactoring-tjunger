using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Text scoreText;
    private int score = 0;
    private const string menuScene = "MenuScene";

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void GameOver()
    {
        ObstacleSpawner.instance.gameOver = true;
        StopScrolling();
        gameOverPanel.SetActive(true);
    }

    void StopScrolling()
    {
        TextureScroll[] scrollingObjects = FindObjectsOfType<TextureScroll>();

        foreach(TextureScroll item in scrollingObjects)
        {
            item.scroll = false;
            Debug.Log(item.name);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(MenuController.mainScene);
    }a

    public void Menu()
    {
        SceneManager.LoadScene(menuScene);
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
