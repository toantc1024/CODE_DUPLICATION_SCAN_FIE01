using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float initGameSpeed = 5f;
    public float gameSpeedIncrease = 0.1f;
    public float gameSpeed {  get; private set; }
    public float score = 0f;
    public TextMeshProUGUI gameOverText;
    public Button retryButton;
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI scoreText;


    private Player player;
    private Spawner spawner;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } 
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    public void OnDestroy()
    {
        if (Instance == this) 
        {
            Instance = null;
        }
    }

    private void Start()
    {
        PlayerPrefs.DeleteKey("hiscore"); // Xóa key "hiscore" nếu nó tồn tại
        PlayerPrefs.SetFloat("hiscore", 0);
        PlayerPrefs.Save();

        player = FindFirstObjectByType<Player>();
        spawner = FindFirstObjectByType<Spawner>();
        NewGame();
    }

    public void NewGame()
    {
        Obstacle[] obstacles = Object.FindObjectsByType<Obstacle>(FindObjectsSortMode.None);
        foreach (var obstacle in obstacles)
        {
            Destroy(obstacle.gameObject);
        }

        score = 0f;
        gameSpeed = initGameSpeed;
        enabled = true;
        player.gameObject.SetActive(true);
        spawner.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);

        UpdateHighscore();
    }

    public void GameOver()
    {
        gameSpeed = 0f;
        enabled = false;

        player.gameObject.SetActive(false);
        spawner.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(true);
        retryButton.gameObject.SetActive(true);

        UpdateHighscore();
    }

    private void Update()
    {
        gameSpeed += gameSpeedIncrease * Time.deltaTime;
        score += gameSpeed * Time.deltaTime;
        scoreText.text = Mathf.FloorToInt(score).ToString("D5");
    }

    private void UpdateHighscore()
    {
        float hiscore = PlayerPrefs.GetFloat("hiscore", 0);

        if (score > hiscore)
        {
            hiscore = score;
            PlayerPrefs.SetFloat("hiscore", hiscore);
        }

        highscoreText.text = Mathf.FloorToInt(hiscore).ToString("D5");
    }
}
