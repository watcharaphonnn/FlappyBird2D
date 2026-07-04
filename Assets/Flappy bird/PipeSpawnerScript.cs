using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;

    [SerializeField] private float spawnRate = 1.5f;
    private float timer = 0f;

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;  
        }
    }

    private void SpawnPipe()
    {
        Instantiate(pipePrefab, transform.position, Quaternion.identity);
    }
}
