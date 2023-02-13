using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
   
    [SerializeField] private CinemachineVirtualCamera camera1;
    [SerializeField] private CinemachineVirtualCamera camera2;
    void Start()
    {

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            turnOnCamera(camera1, camera2);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            turnOnCamera(camera2, camera1);
        }
    }


    private void turnOnCamera(CinemachineVirtualCamera CamToTurnOn, CinemachineVirtualCamera otherCamera)
    {
        CamToTurnOn.gameObject.SetActive(true);
        otherCamera.gameObject.SetActive(false);

    }

}
