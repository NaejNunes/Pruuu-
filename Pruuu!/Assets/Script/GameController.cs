using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static int milhoPonto;
    public  Text txtMilhoPonto, txtMinutos, txtSegundos;
    public int milesimos, segundos, minutos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtMilhoPonto.text = "" + milhoPonto;
        txtMinutos.text = "" + minutos;
        txtSegundos.text = "" + segundos;


        milesimos = milesimos - 1;

        if (milesimos == 0)
        {
            milesimos = 60;
            segundos = segundos - 1;
        }

        if (segundos == 0)
        {
            segundos = 60;
            minutos = minutos - 1;
        }

        if (minutos == 0)
        {
            Debug.Log("O jogo acabou");
        }      
    }

    
}