using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    public float deadZone = -10;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;

        if (transform.position.z <= deadZone)
        {
            DestroyImmediate(gameObject);
        }
    
    }
}
