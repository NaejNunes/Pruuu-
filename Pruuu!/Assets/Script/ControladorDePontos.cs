using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDePontos : MonoBehaviour
{
    public static  int pontos;
    public  Text txtPlacar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtPlacar.text = "" + pontos;
    }
    public static void ContadorDePontos()
    {      
        pontos = pontos + 1;
    }
   
}
