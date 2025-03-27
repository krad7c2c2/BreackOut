using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Caucho : Bloque
{

    //propiedades de bloque: 
    //bool velocidadDoble = true; //retorna la pelota a una velocidad mayor. 
    //bool dobleImpacto = true; // al rebotar la pelota e impactar con otros bloques destruye todos en linea recta, siempre y cuando sean de tipo madera y cristal. 
   

    // Start is called before the first frame update
    void Start()
    {
        resistencia = 6;
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }


}
