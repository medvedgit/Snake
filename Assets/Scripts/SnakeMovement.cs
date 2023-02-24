using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public int Length = 1;

    public TMP_Text PointsText;

    private SnakeTales componentSnakeTail;


    private void Start()
    {
        componentSnakeTail = GetComponent<SnakeTales>();

        for (int i = 0; i < Length; i++) componentSnakeTail.AddCircle();

        PointsText.SetText(Length.ToString());
    }


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            Length++;
            componentSnakeTail.AddCircle();
            PointsText.SetText(Length.ToString());
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Length--;
            componentSnakeTail.RemoveCircle();
            PointsText.SetText(Length.ToString());
        }
    }


}
