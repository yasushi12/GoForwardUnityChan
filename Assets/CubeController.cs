﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	//キューブの移動速度
	private float speed = -12;

	//消滅位置
	private float deadLine = -10;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//キューブを移動させる
		transform.Translate(this.speed* Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
			Destroy(gameObject);
        }
	}

	//キューブが地面やキューブ同士で接触するとき音が鳴る
	void OnCollisionEnter2D(Collision2D collision2)
	{
		if (collision2.gameObject.tag == "CubeTag")
		{
			GetComponent<AudioSource>().Play();
		}

		if (collision2.gameObject.tag == "GroundTag")
		{
			GetComponent<AudioSource>().Play();
		}
	}
}
