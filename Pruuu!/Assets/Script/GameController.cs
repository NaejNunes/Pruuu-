using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static int milhoPonto;
    public  Text txtMilhoPonto, txtMinutos, txtSegundos;
    public int milesimos, segundos, minutos;
    public GameObject objMilho;
    public static float x, y;
    int numero;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(this.objMilho, new Vector2(GameController.x + 4f, GameController.y + 2.20f), Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        y = transform.position.y;

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
    public void InstanciarMilho()
    {

       
            numero = Random.Range(1, 3);


            switch (numero)
            {
                case 1:
                    Instantiate(this.objMilho, new Vector2(GameController.x + 4f, GameController.y + 2.20f), Quaternion.identity);
                    break;

                case 2:
                    Instantiate(this.objMilho, new Vector2(GameController.x + 0f, GameController.y + 2.20f), Quaternion.identity);
                    break;

                case 3:
                    Instantiate(this.objMilho, new Vector2(GameController.x - 4f, GameController.y + 2.20f), Quaternion.identity);
                    break;
            }
    }
}
    
