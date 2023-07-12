//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
/*
Array para mov de enemigos tipo smol (bolitas)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOV_SMOL : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Transform[] smol;

    [SerializeField]
    Vector3[] posicionInicial;

    public float velocidad;
    public float extensión;
    void Start()
    {
        posicionInicial = new Vector3[smol.Length];
        posicionInicial[0] = smol[0].position;
        posicionInicial[1] = smol[1].position;

        for (int i = 0; i < smol.Length; i++)
        {
            posicionInicial[i] = smol[i].position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 senoPos = new Vector3(Mathf.Sin(Time.time * velocidad) * extensión, 0, 0);

        for (int i = 0; i < smol.Length; i++)
        {
            smol[i].position = posicionInicial[i] + senoPos;
        }
    }
}
