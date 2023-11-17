using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroid1, asteroid2, asteroid3, asteroid4, asteroid5, asteroid6, asteroid7;
    public float spawnTime;
    public bool spawning = false;
    private int randomAsteroid;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(asteroid1, this.transform);
        Instantiate(asteroid2, this.transform);
        Instantiate(asteroid3, this.transform);
        Instantiate(asteroid4, this.transform);
        Instantiate(asteroid5 , this.transform);
        Instantiate(asteroid6, this.transform);
        Instantiate(asteroid7 , this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if(!spawning)
        {
            SpawnAsteroid();
            spawning = true;
            StartCoroutine(CooldownToSpawn());
        }
    }

    IEnumerator CooldownToSpawn()
    {
        yield return new WaitForSeconds(spawnTime);
        spawning = false;
    }
    public void SpawnAsteroid()
    {
        randomAsteroid = Random.Range(0, 7);
        switch (randomAsteroid)
        {
            case 0:
                Instantiate(asteroid1, this.transform);
                break;
            case 1:
                Instantiate(asteroid2, this.transform);
                break;
            case 2:
                Instantiate(asteroid3, this.transform);
                break;
            case 3:
                Instantiate(asteroid4, this.transform);
                break;
            case 4:
                Instantiate(asteroid5, this.transform);
                break;
            case 5:
                Instantiate(asteroid6, this.transform);
                break;
            case 6:
                Instantiate(asteroid7, this.transform);
                break;
            default:
                Instantiate(asteroid1, this.transform);
                break;
        }
    }
}
