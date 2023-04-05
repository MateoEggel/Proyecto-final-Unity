using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ParedFinal : MonoBehaviour
{

    public float targetTime;
    public bool timerActivo;

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
          
            Debug.Log("Comienza el tiempo" + collision.gameObject.name);
            targetTime = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        }



    }
}
