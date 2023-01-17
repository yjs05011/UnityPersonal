using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRaterMin = 0.5f;
    public float spawnRaterMax = 3.0f;

    public Transform targerTransf =default;
    private float spwanRate = default;
    private float timeAfterSpawn = default;
    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;
        spwanRate = Random.Range(spawnRaterMin, spawnRaterMax);

    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if(timeAfterSpawn>= spwanRate ){
            timeAfterSpawn =0f;
            spwanRate = Random.Range(spawnRaterMax,spawnRaterMin);
            if(targerTransf ==default){

            }
            else
            {
                GameObject bullet = Instantiate(bulletPrefab,
                           transform.position, transform.rotation);
                bullet.transform.LookAt(targerTransf);
                transform.LookAt(targerTransf);
            }

        }
    }
}
