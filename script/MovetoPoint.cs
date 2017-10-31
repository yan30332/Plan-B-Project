using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovetoPoint : MonoBehaviour {

	// Use this for initialization
	public Transform MovePoint;
	public float moveSpeed =0.25f;

	Animator anim ;
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool("walking",false);		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Move()
	{
		transform.position = Vector2.MoveTowards(transform.position,new Vector2(MovePoint.position.x,transform.position.y),moveSpeed);
		
	}
}
