using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examen : MonoBehaviour
{

    public int cantUnidades;
    public int cantDias;
    int cantLitros;
    float cantRecargas = 0.6F;
    int cantKm;
    int precioLitro = 130;
    float precioTotal;
    float precioDescuento = 0.2F;
    int litroConbustible = 15;
    int cantMinimaDias = 5;
    int cantMinimaUnidades = 1;


    // Start is called before the first frame update
    void Start()
    {
        if (cantDias < 5 || cantUnidades < 1) ;
        {
            Debug.Log("Error, la cantidad de días debe ser mayor a 5 y la cantidad de unidades debe ser mayor a 1");
            return;
        }
       if (cantDias > cantMinimaDias & cantUnidades > cantMinimaUnidades)
        {
            precioTotal = cantUnidades * cantMinimaDias * cantLitros * cantRecargas * precioLitro;
            return;
        }


        if (cantLitros > 100)
        {
            precioTotal = cantLitros * precioLitro * precioDescuento;
            return;

        }
        
        


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
