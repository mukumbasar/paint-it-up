﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PerspectiveManager : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera followingCam;
    [SerializeField] CinemachineVirtualCamera climbingCam;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ClimbingCamOn"))
        {
            followingCam.Priority = 9;
            climbingCam.Priority = 10;
            //player rotation
            transform.rotation = Quaternion.Euler(new Vector3(-10,0,0));
        }

        if(other.CompareTag("RotatorCamOn"))
        {
            followingCam.Priority = 10;
            climbingCam.Priority = 9;
            //player rotation
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
    }




}