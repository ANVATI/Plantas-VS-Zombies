using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilHielo : ProyectilHerencia
{
    // Start is called before the first frame update
    void Start()
    {
        speedX = 10;
        damageAmount = 20;
        directionX = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
