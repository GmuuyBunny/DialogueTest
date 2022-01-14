using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public Image actorImage;
    public TMP_Text actorName;
    public TMP_Text messageText;
    public GameObject backgroundBox;
    string animateMessage;

    
    [SerializeField] private AudioClip sound;
    private TextMeshPro textMeshPro;

    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;
    public static bool isActive = false;


    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;

        
        DisplayMessage();
        isActive = true;
    }


    void DisplayMessage()
    {   Message messageToDisplay = currentMessages[activeMessage];
        
        

        StartCoroutine(WriteText(animateMessage, messageText));
    
        Actor actorToDisplay = currentActors[messageToDisplay.actorID];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;
      
    }
    //opens and closes dialogue box
    //ensures correct text is being displayed

    private void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
           
            isActive = false;
            
           
        }
    }


    protected IEnumerator WriteText(string animateMessage, TMP_Text messageText )
    {   

        for (int i = 0; i < animateMessage.Length; i++)
        {
            messageText.text += animateMessage[i];
            yield return new WaitForSeconds(0.1f);
        }
    }
    void Start()
    {
        
    }
  
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isActive == true)
        {
            NextMessage();
        }
      
    }
}
