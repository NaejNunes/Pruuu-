using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHumanoController : MonoBehaviour
{
    public float velocidadeHorizontal;
    public static float x, y;
    public GameObject tiro;

    // Start is called before the first frame update
    void Start()
    {
        //contadorTiro = 5;
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        y = transform.position.y;

        if (Input.GetAxis("Horizontal3") > 0)
        {
            transform.Translate(Vector2.right * velocidadeHorizontal * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal3") < 0)
        {
            transform.Translate(Vector2.left * velocidadeHorizontal * Time.deltaTime);
        }  
    }
    public void OnTriggerEnter2D(Collider2D coco)
    {
        if (coco.gameObject.CompareTag("Coco"))
        {
            SceneManager.LoadScene("GameOver");         
        }
    }
}
        
