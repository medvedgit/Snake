using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    internal static object _transform;
    public Sector GameLevel;
    public Game Game;
    public float thrust;
    public Rigidbody Rigidbody;




    public void Die()
       {
        Game.OnPlayerDied();
       
       }


    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
      
        Renderer sectorRenderer1 = GetComponent<Renderer>();

    }



}

