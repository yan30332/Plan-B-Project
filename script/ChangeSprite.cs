using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class ChangeSprite : MonoBehaviour {

	// Use this for initialization
	public Sprite[] sparray= new Sprite[5];//用於轉換圖片的圖片陣列
	public SpriteRenderer mainren;

	public Fungus.Flowchart talkchart;
	public int i;
	void Start () {
		i=0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public  void changeSprite()
	{
		i++;
		talkchart.SetIntegerVariable("clickTimes",i);
		if(i>5)
		 	i=5;
		mainren.sprite = sparray[i];
	}
}
