using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{

    [SerializeField] BoxCollider SpawnArea;

    private void Start()
    {
        RandomPosition();



    }

    private void RandomPosition()
    {
        Bounds bounds = this.SpawnArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float z = Random.Range(bounds.min.z, bounds.max.z);

        this.transform.position = new Vector3(Mathf.Round(x), 0.5f, Mathf.Round(z));
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Food")
        {
            RandomPosition();
        }
    }
}
