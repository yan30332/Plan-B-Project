using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class LoadSenee : MonoBehaviour {

	public Fungus.Flowchart talkchart;
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
		 	Flowchart.BroadcastFungusMessage ("LoadNextScene");
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			Block targetBlock = talkchart.FindBlock("LoadScence_"+this.gameObject.name);
			talkchart.ExecuteBlock(targetBlock);
		}
	}

}
