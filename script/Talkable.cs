using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class Talkable : MonoBehaviour {

	// Use this for initialization
	public static Flowchart flowchartManager;
	public Fungus.Flowchart talkchart;
	public string onCollision ;//物件名稱
	public static bool isTalking
	{
		get{ return flowchartManager.GetBooleanVariable("isTalking");}
	}
	void Start () {
		onCollision = this.gameObject.name;
	}

	void Awake()
	{
		flowchartManager = GameObject.Find("talkManager").GetComponent<Flowchart>();

	}
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag =="Player")
		{		
			Flowchart.BroadcastFungusMessage (onCollision);
		}
		
		
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag =="Player")
		{
			Flowchart.BroadcastFungusMessage (onCollision);
		}
	}
}
