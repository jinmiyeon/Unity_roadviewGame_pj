using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomatospawn : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRatMin = 0.5f;
    public float spawnRatMax = 0.5f;

    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;

    void Start()
    {
        timeAfterSpawn = 0f;

        spawnRate = Random.Range(spawnRatMin, spawnRatMax);
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);

            spawnRate = Random.Range(spawnRatMin, spawnRatMax);

        }
    }
}
