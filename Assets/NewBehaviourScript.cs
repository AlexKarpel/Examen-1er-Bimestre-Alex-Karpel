using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string productos = "";
    public int precios = 0;
    public int unidades = 0;

    // Start is called before the first frame update
    void Start()
    {
        float descuento = precios * unidades * 0.2f;
        int precio = precios * unidades;
        float preciocondescuento = precio - descuento;

        if (unidades < 3)
        {
            Debug.Log("Para aplicar el descuento, tienen que haber mas de 3 unidades");
        } else if(unidades > 3)
        {
            Debug.Log("El precio total es de"+precio+"pesos, el descuento es de"+descuento+"pesos y  con el descuento te queda en"+preciocondescuento+"pesos");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
