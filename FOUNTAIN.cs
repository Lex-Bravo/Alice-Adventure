//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
/*
 Cod simple para animación de la fuente
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOUNTAIN : MonoBehaviour
{
    private Animator animator;
    private Vector3 change;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;

        if (change != Vector3.zero)
        {
            transform.Translate(new Vector3(change.x, change.y));

            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);

        }
    }
}
