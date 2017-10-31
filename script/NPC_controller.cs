using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_controller : MonoBehaviour {

	// Use this for initialization
	SpriteRenderer rend;
	public Transform walkpoint;//要走去的點
	Animator anim;
	public float moveSpeed =0.25f;//移動速度
	public bool Visible;//此NPC是否可以被看見
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool("isWalking",false);
		rend = this.gameObject.GetComponent<SpriteRenderer>();
		rend.enabled = Visible;
	}
	
	// Update is called once per frame
	void Update () {
		//WalkToPoint();
	}
	IEnumerator NPC_changeVisible()
	{
		rend.enabled = !rend.enabled;
		yield return new WaitForSeconds(2);

	}

	void StartWalk()
	{
		anim.SetBool("isWalking",true);
		StartCoroutine(WalkToPoint());
	}
	IEnumerator WalkToPoint()//走向指定的點
	{
		/*anim.SetBool("isWalking",true);
		while(true)
		{
			transform.position = Vector2.MoveTowards(transform.position,new Vector2(walkpoint.position.x,transform.position.y),moveSpeed);
			if(transform.position.x == walkpoint.position.x)
			{
				anim.SetBool("isWalking",false);
				//NPC_changeVisible();
				break;
			}
		}*/
		while(true)
		{
			if(Vector2.Distance(this.transform.position, walkpoint.transform.position) < 0.1f)
			{
				transform.position = walkpoint.transform.position;
				NPC_changeVisible();
				break;
			}
			else
			{
				float maxDistanceDelta = Time.deltaTime * moveSpeed;

				transform.position = Vector2.MoveTowards(this.transform.position, walkpoint.transform.position, maxDistanceDelta);					
			}
			yield return null;
		}	
		
	}
    protected void Flip()    
    {
		rend.flipX = true;
        /*Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;*/

    }
	//設定FUNGUS變數判斷NPC是否到達指定地點
	public void arrive()
	{

	}

}
