using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player") {
            Debug.Log("HOLA");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
    }
}
