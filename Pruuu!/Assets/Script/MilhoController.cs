using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilhoController : GameController
{
    public float tempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D milho)
    {       
            InstanciarMilho();
            Destroy(gameObject);        
    }
}
