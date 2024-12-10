using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonAnimHandler : MonoBehaviour
{
   Button button;

   void Start()
   {
       button = GetComponent<Button>();
   }

   private void OnTriggerEnter(Collider other)
   {
      
   }
   
}
