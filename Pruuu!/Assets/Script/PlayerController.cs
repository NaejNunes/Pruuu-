using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float velocidadeHorizontal;
    public static float x, y;
    public GameObject tiro;
    int coco;

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

        if (Input.GetAxis("Horizontal2") > 0)
        {
            transform.Translate(Vector2.right * velocidadeHorizontal * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal2") < 0)
        {
            transform.Translate(Vector2.left * velocidadeHorizontal * Time.deltaTime);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            coco = GameController.milhoPonto;

            if (coco >= 1)
            {
                GameController.milhoPonto = GameController.milhoPonto - 1;
                coco = coco - 1;
                Instantiate(this.tiro, new Vector2(PlayerController.x + -0.1f, PlayerController.y - 0.2f), Quaternion.identity);
            }
             
        }
    }
        public void OnTriggerEnter2D(Collider2D milho)
        {
            if (milho.gameObject.CompareTag("Milho"))
            {
            GameController.milhoPonto = GameController.milhoPonto + 1;
            }
        }
}