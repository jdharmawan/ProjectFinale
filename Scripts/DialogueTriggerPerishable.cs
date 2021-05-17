using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerPerishable : MonoBehaviour
{
	public Dialogue dialogue;

	public void OnTriggerEnter(Collider conversation)
	{
		if (conversation.CompareTag("Player"))
		{
			TriggerDialogue();
			Destroy(gameObject);
		}
	}

	public void TriggerDialogue()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}
}
