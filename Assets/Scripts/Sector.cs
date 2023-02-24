using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sector : MonoBehaviour
{
    public bool IsGood = true;
    public Material TrackMaterial;
    public Material BoardMaterial;
    

   

    private void Awake()
    {
        UpdateMaterial();
    }

    private void UpdateMaterial()
    {
        Renderer sectorRenderer1 = GetComponent<Renderer>();
        sectorRenderer1.sharedMaterial = IsGood ? TrackMaterial : BoardMaterial;
    }
   

}

