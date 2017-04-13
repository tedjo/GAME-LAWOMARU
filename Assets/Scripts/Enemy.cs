using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	Transform playerT;

	// Use this for initialization
	void Start () {
		playerT = GameObject.FindGameObjectWithTag("Player").transform;	
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector2.Distance (transform.position, playerT.position) < 4) {
			//transform.position = Vector2.MoveTowards(transform.position,playerT.position,1f);
			if(playerT.position.x<transform.position.x){
				transform.Translate(new Vector3(-0.3f*Time.deltaTime,0,0));
			}else{
				transform.Translate(new Vector3(0.3f*Time.deltaTime,0,0));
			}
		}
	}
}
