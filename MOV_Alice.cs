//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
/*
 Este script se utilizara para generar el control del avatar jugador y sus animaciones
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOV_Alice : MonoBehaviour
{
    public int vida;
    public float velocidad = 10f;
    private Rigidbody2D myrigidbody;
    private Vector3 change;
    private Animator animator;

    [SerializeField]
    MOV_Alice player_vida;

    [SerializeField]
    public SpriteRenderer spritePlayer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        myrigidbody = GetComponent<Rigidbody2D>();
        vida = 3;
        velocidad = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * velocidad;
        change.y = Input.GetAxisRaw("Vertical") * Time.deltaTime * velocidad;

        if (change != Vector3.zero)
        {
            transform.Translate(new Vector3(change.x, change.y));

            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        }else{
            animator.SetBool("moving", false);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        {
            if (collision.gameObject.tag == "Player")
            {
                player_vida.vida--;

                Debug.Log("al infinito y más allá");
            }

            if (vida == 0)
            {
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }


        }
    }
}
