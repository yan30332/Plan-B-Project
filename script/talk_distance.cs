using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class talk_distance : MonoBehaviour {

	// Use this for initialization
	//public float sight = 3f;
	public Transform target;
	public Fungus.Flowchart talkchart;
	public float Distance ;
	bool clickable ;
	bool alreadyset;//一個變數去判斷是否已經設置過clickable必免平凡呼叫FUNGUS
	public string variableName ;
	void Start () {
		alreadyset = false;
		variableName  = this.gameObject.name+"Clickable";

	}
	

	void FixedUpdate()
	{
		clickable = (Vector2.Distance(this.transform.position,target.transform.position)<Distance);
		if(!clickable&&alreadyset==true) 
		{
			talkchart.SetBooleanVariable(variableName,false);
			alreadyset = false;
		}
		if(clickable&&alreadyset==false)
		{
			talkchart.SetBooleanVariable(variableName,true);
			alreadyset =true;
		}
	}

}
