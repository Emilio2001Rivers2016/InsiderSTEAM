using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Prueba si Mario est� en el piso
 * Autor: Carlos David Toapanta Noro�a
 * Matr�cula: A01657439
 */

public class FloorTest : MonoBehaviour
{
    public static bool isInFloor;

    private void OnTriggerEnter2D(Collider2D other)
    {
        isInFloor = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isInFloor = false;
    }

}
