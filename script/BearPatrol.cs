using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearPatrol : MonoBehaviour {

	// Use this for initialization
	public Transform[] patrolPoint;
	int currentPoint;
	public float moveSpeed =0.25f;
	public float timeStill=2f;
	public Transform target;
	Animator anim ;
	void Start () {
		StartCoroutine("Patrol");
		anim = GetComponent<Animator>();
		anim.SetBool("walking",true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator Patrol()
	{
		while(true)
		{
		//在固定的點巡邏
			if(transform.position.x == patrolPoint[currentPoint].position.x)
			{
				currentPoint++;
				anim.SetBool("walking",false);
				yield return new WaitForSeconds(timeStill);
				anim.SetBool("walking",true);
			}
			if(currentPoint==patrolPoint.Length)
			{
				currentPoint=0;
				anim.SetBool("walking",false);
				yield return new WaitForSeconds(timeStill);
				anim.SetBool("walking",true);				
			}
			transform.position = Vector2.MoveTowards(transform.position,new Vector2(patrolPoint[currentPoint].position.x,transform.position.y),moveSpeed);
			if(transform.position.x<patrolPoint[currentPoint].position.x)
			{
				this.transform.localScale = new Vector3(-0.07177514f,0.07177514f,0.07177514f);
			}
			else if(transform.position.x>patrolPoint[currentPoint].position.x)
			{
				this.transform.localScale = new Vector3(0.07177514f,0.07177514f,0.07177514f);
			}
			yield return null;
		}
	
	}
}
