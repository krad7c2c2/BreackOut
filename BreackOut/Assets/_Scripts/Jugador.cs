using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    [SerializeField] public int limiteX = 23; //
    [SerializeField] public float velocidadPadle = 35f; //


    Transform transform;
    Vector3 mousePos2D;
    Vector3 mousePos3D;

    // Start is called before the first frame update
    void Start()
    {
        transform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {

        //mueve con el teclado
        if (Input.GetKey(KeyCode.RightArrow)) { //mueve a la derecha
            transform.Translate(Vector3.down * velocidadPadle * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector3.up * velocidadPadle * Time.deltaTime);
        }
        Vector3 pos = transform.position;
        if (pos.x < -limiteX)
        {
            pos.x = -limiteX;
        }
        else if (pos.x > limiteX)
        {
            pos.x = limiteX;
        }
        transform.position = pos; //cambia la posicion del objeto
        

        //mueve con el control..
        /*
        transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * velocidadPadle * Time.deltaTime);
        Vector3 pos = transform.position;
        if (pos.x < -limiteX)
        {
            pos.x = -limiteX;
        }
        else if (pos.x > limiteX)
        {
            pos.x = limiteX;
        }
        transform.position = pos; //cambia la posicion del objeto
        */


        /* actualizar con el mouse
        //mueve el paddle
         //mousePos2D = Input.mousePosition;
        //mousePos2D.z = -Camera.main.transform.position.z;
        //mousePos3D = Camera.main.ScreenToViewportPoint(mousePos2D); //interpolar las cordenadas al videojuego

        Vector3 pos = this.transform.position; //obtiene la posiscion
        pos.x = mousePos3D.x;  //actualiza la posicion en el eje x de la posicion del raton
        if (pos.x < -limiteX) {
            pos.x = -limiteX;
        } else if (pos.x > limiteX) {
            pos.x = limiteX;
        }
        this.transform.position = pos; //cambia la posicion del objeto
        */

    }
}
