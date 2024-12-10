using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    [SerializeField]
    Animator PlayerAnimator;
    [SerializeField]
    Animator CameraAnimator;
    
    
    private void Awake()
    {
        Time.timeScale = 1;
       
    }

    void Start()
    {
        Debug.Log(PlayerAnimator.GetBool("Started"));
        PlayerAnimator.SetBool("Started", false);
        CameraAnimator.SetBool("StartCam", false);   

    }

  
    void Update()
    {
        
    }


    public void StartSequence()
    {
        
        PlayerAnimator.SetBool("Started", true);
        CameraAnimator.SetBool("StartCam", true); 
        //Time.timeScale = 1;
    }

    public void QuitApp()
    {
        Application.Quit();

    }


    
}
