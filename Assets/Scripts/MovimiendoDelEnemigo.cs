using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimiendoDelEnemigo : MonoBehaviour
{
    public float rangoDeAlerta;
    public LayerMask capaDelJugador;
    bool estarAlerta;
    public Transform jugador;
    public float speed;
    
    [SerializeField] enum objectColor { Verde, Azul, Negro}
    [SerializeField] objectColor currentColor;
    [SerializeField] GameObject Enemigo;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        estarAlerta = Physics.CheckSphere(transform.position, rangoDeAlerta, capaDelJugador);
        if (estarAlerta == true)
        {

            transform.LookAt(new Vector3(jugador.position.x, jugador.position.y, jugador.position.z));
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x, jugador.position.y, jugador.position.z), speed * Time.deltaTime);
        }

        MaterialSwitch();


    }

    

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
    }

    private void MaterialSwitch() { 

        switch(currentColor)
        {
            case objectColor.Verde:
                Enemigo.GetComponent<Renderer>().material.color = Color.green;
                break;
            case objectColor.Negro:
                Enemigo.GetComponent<Renderer>().material.color = Color.black; 
                break;
            case objectColor.Azul:
                Enemigo.GetComponent<Renderer>().material.color = Color.blue;
                break;



            default:
                Debug.Log("Not Color");
                    break;
        }
    }

}


