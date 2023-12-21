using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float spawnRate = 3f;
    private float timer = 0f;

    // ----Array machen----
    public GameObject [] BlockSet;

    public GameObject instantiatedBlockSet;
    void Start()
    {
        spawnBlockset();                                // Methode spawnBlockset wird aufgerufen
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;             // timer wird mit der aktuellen Sekundenanzahl addiert, heißt (jede Sekunde = timer + 1) in dem Falle
        }
        else if(timer > spawnRate)
        {
            spawnBlockset();                            // Methode spawnBlockset wird aufgerufen
            timer = 0;                                  // timer wird wieder auf null gesetzt um eine Schleife zu erstellen 
        }
        else
        {
            Debug.LogError("Keine GameObjects mit dem Tag 'BlockSet' gefunden.");
        }
    }

    void spawnBlockset()
    {

        instantiatedBlockSet = Instantiate(BlockSet[Random.Range(0, BlockSet.Length)]);    //Dupliziert ein GameObject
    }
}
