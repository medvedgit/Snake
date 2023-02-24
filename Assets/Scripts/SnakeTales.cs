using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class SnakeTales : MonoBehaviour
{
    public Transform SnakeHead;
    [Range(1f, 2f)]
    public float SphereDistance;
    public GameObject SnakeTalePrefab;

    public List<Transform> tailsSpheres = new List<Transform>();
    private List<Vector3> positions = new List<Vector3>();



    private void Start()
    {
        positions.Add(SnakeHead.position);
       
    }


    private void Update()
    {
        float distance = ((Vector3)SnakeHead.position - positions[0]).magnitude;
        while (distance >= SphereDistance) // if
            {
            positions.Insert(0, SnakeHead.position);
            positions.RemoveAt(positions.Count - 1);

            distance -= SphereDistance;
            }
        for (int i = 0; i < tailsSpheres.Count; i++)
            {
            tailsSpheres[i].position = Vector3.Lerp(positions[i + 1], positions[i], distance / SphereDistance);
        }

    }
    public void AddCircle()
    {
        Transform circle = Instantiate(SnakeHead, positions[positions.Count - 1], Quaternion.identity, transform);
        tailsSpheres.Add(circle);
        positions.Add(circle.position);
    }

    public void RemoveCircle()
    {
        Destroy(tailsSpheres[0].gameObject);
        tailsSpheres.RemoveAt(0);
        positions.RemoveAt(1);
    }

    internal static void Add(object position)
    {
        throw new NotImplementedException();
    }
}
