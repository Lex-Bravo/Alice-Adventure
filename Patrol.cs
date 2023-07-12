//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
/*
Array para mov de enemigos tipo bat
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField]
    Transform[] bat;

    [SerializeField]
    Vector3[] posicionInicial;

    public float velocidad;
    public float extensión;
    void Start()
    {

        for (int i = 0; i < bat.Length; i++)
        {
            posicionInicial[i] = bat[i].position;
        }
    }
    void Update()
    {
        Vector3 senoPos = new Vector3(Mathf.Sin(Time.time * velocidad) * extensión, 0, 0);

        for (int i = 0; i < bat.Length; i++)
        {
            bat[i].position = posicionInicial[i] + senoPos;
        }
    }

}
