using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
	
    public void OnTriggerEnter(Collider conversation)
	{
		if (conversation.CompareTag("Player"))
		{
			TriggerDialogue();
		}
	}

	public void TriggerDialogue()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}
}
