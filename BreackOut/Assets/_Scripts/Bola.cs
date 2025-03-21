using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    bool isGameStarted = false;
    [SerializeField] public float velociadBola = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        //coloca la bola arriba del paddle
        Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicial.y += 3;
        this.transform.position = posicionInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);

    }

    // Update is called once per frame
    void Update()
    {
        //detecta la tecla espacio
        if (Input.GetKey(KeyCode.Space) || Input.GetButton("Submit")) {
            if (!isGameStarted) {

                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = velociadBola * Vector3.up;

            }
        }

    }
}
