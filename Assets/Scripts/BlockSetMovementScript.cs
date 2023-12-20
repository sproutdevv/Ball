using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] BlockSet;
    public float speed = 5f;
    public float deadZone = -10;

    // Update is called once per frame
    void Update()
    {
        BlockSet = GameObject.FindGameObjectsWithTag("BlockSet");
        transform.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;

        if (transform.position.z <= deadZone)
        {
            while (BlockSet.Length > 0)
            {
                Destroy(BlockSet[0]);
            }
        }
    
    }
}
