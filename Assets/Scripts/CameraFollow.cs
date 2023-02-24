using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public float xOffsetOriginal = 0;
    public float xOffset;
   
    public Vector3 PlatformToCameraOffset;
    public float Speed;

    void Update()
    {
        if (Player == null) return;

        Vector3 targetPosition = Player.transform.position + PlatformToCameraOffset;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);

    }

    public void SetXOffset()
    {
        xOffset = -Player.position.x + transform.position.x;
        if (xOffsetOriginal == 0)
        {
            xOffsetOriginal = -Player.position.x + transform.position.x;
            xOffset = xOffsetOriginal;
        }
        else
        {
            xOffset = xOffsetOriginal;
        }

        void Update()
        {
            if (Player == null) return;

            Vector3 transformPosition = transform.position;
            transformPosition.x = Player.position.x + xOffset;
            transform.position = transformPosition;



        }
    }
}
