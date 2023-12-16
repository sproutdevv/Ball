using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject BlockSet2;
    public float spawnRate = 1;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Instantiate(BlockSet2, transform.position, transform.rotation);
            timer = 0;
        }

        
    }
}
