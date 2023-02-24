using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Player player;
    [Range(1f, 10f)]
    public float Sensitivity;
    [Range(1f, 100f)]
    public float Speed;
    public GameObject SnakeTalePrefab;

    private Vector3 _previousMousePosition;

    void Update()
    {
        player.Rigidbody.velocity = new Vector3(0, 0, Speed);
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            player.Rigidbody.velocity = new Vector3(delta.x * Sensitivity, 0, Speed);
        }
        _previousMousePosition = Input.mousePosition;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food") ;
        {
            Destroy(collision.gameObject);


            var AddCircle = Instantiate(SnakeTalePrefab);
            SnakeTales.Add(SnakeTalePrefab.transform);
        }
    }
}
