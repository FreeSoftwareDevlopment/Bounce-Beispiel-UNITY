﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEPLAYER : MonoBehaviour
{
	public float speed = 6.0f;
    void Start()
    {
        
    }
    void Update()
    {
         if(Input.GetKey(KeyCode.D))
        {
			transform.Translate(Vector3.right * speed);
		}
		if(Input.GetKey(KeyCode.A))
        {
			transform.Translate(Vector3.left * speed);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
        {
			transform.Translate(Vector3.left * speed);
		}
		if(Input.GetKey(KeyCode.RightArrow))
        {
			transform.Translate(Vector3.right * speed);
		}
    }
}
