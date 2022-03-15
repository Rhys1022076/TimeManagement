using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTasks : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] spawnableObjects;

    void Start()
    {
        Invoke("SpawnStart", 1f);
    }

    IEnumerator Spawn()
    {
        int gameObjectIndex = Random.Range(0, spawnableObjects.Length);
        int locationIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(spawnableObjects[gameObjectIndex], spawnPoints[locationIndex]);
        yield return new WaitForSeconds(1f);
        SpawnStart();
    }

    private void SpawnStart()
    {
        StartCoroutine(Spawn());
    }

    public void SpawnStop()
	{
        StopAllCoroutines();
	}

    void Update()
    {
        if (Time.timeSinceLevelLoad >= 27f)
        {
            StopAllCoroutines();
        }
    }
}