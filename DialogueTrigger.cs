using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DialogueTrigger : MonoBehaviour
{

    //holds data about messages and actors
    //actors are like characters
    //sends messages to manager
    
    
    
    public Message[] messages;
    public Actor[] actors;

    public void StartDialogue()
    {
     
     FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);

    }

   
}

[System.Serializable]
public class Message 
{
    public int actorID;
    public string message;
}

[System.Serializable]
public class Actor
{
    public string name;
    public Sprite sprite;
}

