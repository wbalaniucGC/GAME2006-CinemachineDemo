using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinamachineController : MonoBehaviour
{

    public CinemachineVirtualCamera playerCam;
    public CinemachineVirtualCamera groupCam;
    public CinemachineVirtualCamera thirdCam;

    private Animator anim;
    private bool isGroupCamera = true;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isGroupCamera = !isGroupCamera;
            anim.SetBool("isGroupCamera", isGroupCamera);
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {

        }
    }

    private void ModifyCameras(int player, int group, int third)
    {
        playerCam.Priority = player;
        groupCam.Priority = group;
        thirdCam.Priority = third;
    }
}
