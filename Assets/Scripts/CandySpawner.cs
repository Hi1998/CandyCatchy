using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField]
    float maxX;

    [SerializeField]
    float spawnInterval;

    [SerializeField]
    GameObject[] Candies;

    public static CandySpawner instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartSpawningCandies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandies()
    {
        int randomSpawn = Random.Range(0, Candies.Length);

        float randomX = Random.Range(-maxX, maxX);
        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z); 

        Instantiate(Candies[randomSpawn], randomPos, transform.rotation);
    }

    IEnumerator SpawnCandy()
    {
        yield return new WaitForSeconds(2f);

        while(true)
        {
            SpawnCandies();

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void StartSpawningCandies()
    {
        StartCoroutine("SpawnCandy");
    }

    public void StopSpawiningCanides()
    {
        StopCoroutine("SpawnCandy");
    }
}
