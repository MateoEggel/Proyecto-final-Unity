using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaccion : MonoBehaviour
{
    public float rayDistance;
    private new Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = transform.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.red);

        if (Input.GetButtonDown("Interactable"))
        {

        
        
            RaycastHit hit; 
        if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactable"))){
                hit.transform.GetComponent<Interactuar>().Interact();
        }
        }
    }
}
