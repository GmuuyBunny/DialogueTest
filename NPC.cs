using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
   public DialogueTrigger trigger;
  
   

    


   void Update()
   {           
    if(Input.GetKeyDown(KeyCode.R))
    {
       trigger.StartDialogue();
    }
    
   }
   
}
