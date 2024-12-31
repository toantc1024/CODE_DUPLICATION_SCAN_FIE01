using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SmallTreeOne;
    public GameObject SmallTreeTwo;
    public GameObject LargeTreeOne;
    public GameObject LargeTreeTwo;
    public GameObject TreeThree;
    public GameObject TreeFour;
    public GameObject Bird;

    public Transform spawnPoint; // Spawn location
    public float score => GameManager.Instance != null ? GameManager.Instance.score : 0f;

    private CLinkedList obstacleList;
    private ONode currentNode;

    public float minSpawnRate = 1f;
    public float maxSpawnRate = 2f;
    public float spawnInterval;
    private float timer = 0f; // Timer for spawn intervals  

    public void Start()
    {
        spawnInterval = Random.Range(minSpawnRate, maxSpawnRate);
        // Initialize the circular linked list and add initial obstacles
        obstacleList = new CLinkedList();
        obstacleList.add_back(new ONode(SmallTreeOne));
        obstacleList.add_back(new ONode(SmallTreeTwo));
        currentNode = obstacleList.head; // Start from the head
    }

    public void Update()
    {
        // Update obstacle list based on score
        UpdateObstacleList();

        // Handle spawning based on the timer
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnObstacle();
            timer = spawnInterval;

            spawnInterval = Random.Range(minSpawnRate, maxSpawnRate);
        }

    }

    private void UpdateObstacleList()
    {
        if (score >= 200f)
        {
            obstacleList.remove(new ONode(SmallTreeTwo));
        }
        else if (score >= 100f && Mathf.FloorToInt(score) % 50 == 0)
        {
            obstacleList.reverse();
        }
        else if (score >= 50f)
        {
            if (!obstacleList.exist(Bird))
            {
                obstacleList.add_back(new ONode(Bird));
            }
        }
        else if (score >= 30f)
        {
            if (!obstacleList.exist(LargeTreeOne))
            {
                obstacleList.add_back(new ONode(LargeTreeOne));
                obstacleList.add_back(new ONode(LargeTreeTwo));
                obstacleList.add_back(new ONode(TreeThree));
                obstacleList.add_back(new ONode(TreeFour));
            }
        }
    }

    private void SpawnObstacle()
    {
        if (currentNode == null) return;

        // Spawn the current obstacle at the spawn point
        GameObject obstacle = Instantiate(currentNode.obstacle);
        obstacle.transform.position += transform.position;
        // Move to the next obstacle in the circular linked list
        currentNode = currentNode.next;
    }

}
