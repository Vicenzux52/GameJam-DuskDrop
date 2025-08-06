using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] unitPrefabs;
    [SerializeField] GameObject[] spots;
    [SerializeField] private float spawnInterval = 2f;
    [SerializeField] int difficultyTreshold = 10;
    [SerializeField] float minSpawnInterval = 0.5f;
    int count = 0;
    private float[] nextSpawnTime = new float[3];
    bool started = false;

    public void Start()
    {
        Nexus.Self.AddSelf(this);
    }
    public void StartCombat()
    {
        nextSpawnTime[0] = Time.time + spawnInterval * Random.Range(0.8f, 1.2f);
        nextSpawnTime[1] = Time.time + spawnInterval * Random.Range(0.8f, 1.2f);
        nextSpawnTime[2] = Time.time + spawnInterval * Random.Range(0.8f, 1.2f);
        started = true;
    }

    private void Update()
    {
        if (!started) return;
        if ((count + 1) % difficultyTreshold == 0)
        {
            spawnInterval -= 0.1f;
            if (spawnInterval <= minSpawnInterval) spawnInterval = minSpawnInterval;
        }
        if (Time.time >= nextSpawnTime[0])
        {
            SpawnUnit(0);
            nextSpawnTime[0] = Time.time + spawnInterval * Random.Range(0.8f, 1.2f);
        }
        if (Time.time >= nextSpawnTime[1])
        {
            SpawnUnit(1);
            nextSpawnTime[1] = Time.time + spawnInterval * Random.Range(0.8f, 1.2f);
        }
        if (Time.time >= nextSpawnTime[2])
        {
            SpawnUnit(2);
            nextSpawnTime[2] = Time.time + spawnInterval * Random.Range(0.8f, 1.2f);
        }
    }

    private void SpawnUnit(int spot)
    {
        GameObject temp = Instantiate(unitPrefabs[Random.Range(0,unitPrefabs.Length)], spots[spot].transform.position, Quaternion.identity);
        temp.transform.localScale = new Vector3(140, 140, 140);
        count++;
    }
}
