using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Cristal : Bloque
{

    //propiedades de bloque: 
    //bool reboteInverso = true; //no cambia la dirección de donde viene la pelota. 
    //bool fractura = true; //si la pelota pega en el centro el bloque se rompe,

    // Start is called before the first frame update
    void Start()
    {
        resistencia = 2;
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }


}
