using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopTrigger : MonoBehaviour
{
	public static bool ShopIsOpen = false;

	public Dialogue dialogue;
	public GameObject shopUI;
	public GameObject player;

	public void OnTriggerEnter(Collider conversation)
	{
		if (conversation.CompareTag("Player"))
		{
			TriggerDialogue();
			shopUI.SetActive(true);
		}
	}

	public void TriggerDialogue()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}

	public void CloseShop()
	{
		shopUI.SetActive(false);
	}
}
