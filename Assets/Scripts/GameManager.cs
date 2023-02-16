using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    float timer;
    public Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        TimerText.text = "TIME: " + timer.ToString("n2");
    }
   
    
    private void Update()
    {
        timer += Time.deltaTime;
        TimerText.text = "TIME: " + timer.ToString("n2");

       
    }

   
        
}
