using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBird : Bird
{
    public float fieldofImpact;
    public float force;

    public LayerMask LayerToHit;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (State == BirdState.Thrown )
        {
            explode();
        }
    }

    void explode()
    {
    
    }
}
