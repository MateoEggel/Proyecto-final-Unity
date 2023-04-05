using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pared : MonoBehaviour
{
    public float targetTime;
    public bool timerActivo;
    [SerializeField] Vector3 Position;
    [SerializeField] Quaternion Rotation;

    void Start()
    {
        targetTime = 0;
    }


    void Update()
    {






    }

    private void OnCollisionStay(Collision collision)
    {
        targetTime += Time.deltaTime;
        Debug.Log(targetTime);


        if (targetTime > 0.1)
        {
            transform.rotation = Rotation;
            transform.position = Position;
            Debug.Log("Comienza el tiempo" + collision.gameObject.name);
            targetTime = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }



    }





 
}
