using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnDelay;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(enemy, new Vector3(15, UnityEngine.Random.Range(-3.0f, 5.0f), 0), transform.rotation);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
