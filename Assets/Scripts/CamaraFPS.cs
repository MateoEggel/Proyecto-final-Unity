using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFPS : MonoBehaviour
{
    public Vector2 sensibility;
    private new Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        camera = transform.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");

        if (hor != 0 )
        {
            transform.Rotate(Vector3.up * hor * sensibility.x);
        }

        if ( ver != 0 )
        {
            camera.Rotate(Vector3.left * ver * sensibility.y);    
        }

    }
}
