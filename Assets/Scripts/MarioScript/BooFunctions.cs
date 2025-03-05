using UnityEngine;

public class BooFunctions : MonoBehaviour
{
    public GameObject booprefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        for(int i = 0; i < Random.Range(20, 40); i++)
        {
            Vector3 SpawnPosition = new Vector3(Random.Range(-2.25f, 0.167f), 0.97f, Random.Range(-10.6f, -8.019f));

            /*
            Vector3 spawnPosition2 = Vector3.zero;

            spawnPosition2.x = Random.Range(-2.25f, 0.167f);
            spawnPosition2.y = .97f;
            spawnPosition2.z = Random.Range(-10.6f, -8.019f);*/

            GameObject go = Instantiate(booprefab, SpawnPosition, booprefab.transform.rotation);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
