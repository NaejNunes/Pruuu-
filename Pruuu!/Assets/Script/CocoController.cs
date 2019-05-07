﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocoController : MonoBehaviour
{
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, velocidade, 0);
    }
    public void OnCollisionEnter2D(Collision2D bk)
    {
        if (bk.gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }
    }
}
