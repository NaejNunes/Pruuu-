using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilhoController1 : MonoBehaviour
{
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
       
        if (milho.gameObject.CompareTag("PlayerPombo"))
        {
            Destroy(gameObject);
        }
    }
}
