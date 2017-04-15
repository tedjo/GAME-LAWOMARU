﻿using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {

	public Transform[] backgrounds;
	private float[] parallaxScales;
	public float smooting =1f;

	private Transform cam;
	private Vector3 previuousCamPos;

	void awake(){
		cam = Camera.main.transform;
	}

	// Use this for initialization
	void Start () {
		previuousCamPos = cam.position;

		parallaxScales = new float[backgrounds.Length];

		for (int i=0; i<backgrounds.Length; i++) {
			parallaxScales[i] = backgrounds[i].position.z*-1;
		}
	}
	
	// Update is called once per frame
	void Update () {
			for (int  i = 0; i < backgrounds.Length; i++){

				float parallax = (previuousCamPos.x - cam.position.x )*parallaxScales[i];

				float backgroundTargetPosX = backgrounds[i].position.x + parallax;

				Vector3 backgroundTargerPos = new Vector3 (backgroundTargetPosX,backgrounds[i].position.y, backgrounds[i].position.z);

			backgrounds[i].position = Vector3.Lerp (backgrounds[i].position, backgroundTargerPos, smooting*Time.deltaTime);

			}
		previuousCamPos = cam.position;
	}
}
