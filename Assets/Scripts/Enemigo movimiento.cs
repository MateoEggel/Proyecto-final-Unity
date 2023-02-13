using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigomovimiento : MonoBehaviour
{

    public float rangoDeAlerta;
    public LayerMask capaDelJugador;
    bool estarAlerta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        estarAlerta = Physics.CheckSphere (transform.position,rangoDeAlerta,capaDelJugador);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
    }
}
