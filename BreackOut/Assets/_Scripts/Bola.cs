using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bola : MonoBehaviour
{

    bool isGameStarted = false;
    [SerializeField] public float velociadBola = 10.0f;

    Vector3 ultimaPosicion = Vector3.zero;
    Vector3 direccion = Vector3.zero;
    Rigidbody rigidbody;
    private ControlBordes control;
    public UnityEvent BolaDestruida;


    private void Awake()
    {
        control = GetComponent<ControlBordes>();
    }


    // Start is called before the first frame update
    void Start()
    {
        //coloca la bola arriba del paddle
        Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicial.y += 3;
        this.transform.position = posicionInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
        rigidbody = this.gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if (control.salioAbajo) {
            BolaDestruida.Invoke();
            Destroy(this.gameObject);
        }
        if (control.salioArriba) {
            direccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco el borde superior");
            direccion.y *= -1;
            direccion.Normalize();
            rigidbody.velocity = velociadBola * direccion;
            control.salioArriba = false;
            control.enabled = false;
            Invoke("HabiliatarControl", 0.5f); //despues de medio segundo se ejecuta
        }
        if (control.salioDerecha)
        {
            direccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco el borde derecho");
            direccion.x *= -1;
            direccion.Normalize();
            rigidbody.velocity = velociadBola * direccion;
            control.salioDerecha = false;
            control.enabled = false;
            Invoke("HabiliatarControl", 0.5f);

        }
        if (control.salioIzquierda)
        {
            direccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco el borde izquierdo");
            direccion.x *= -1;
            direccion.Normalize();
            rigidbody.velocity = velociadBola * direccion;
            control.salioIzquierda = false;
            control.enabled = false;
            Invoke("HabiliatarControl", 0.5f);
        }



        //detecta la tecla espacio
        if (Input.GetKey(KeyCode.Space) || Input.GetButton("Submit")) {
            if (!isGameStarted) {

                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = velociadBola * Vector3.up;

            }
        }

    }

    private void HabiliatarControl() {
        control.enabled = true;
    }


    private void FixedUpdate()
    {
        ultimaPosicion = transform.position;
    }

    private void LateUpdate()
    {
        if (direccion != Vector3.zero) direccion = Vector3.zero;
    }
}
