﻿using System.Collections;
using UnityEngine;

public class Rotate : MonoBehaviour {


	void Update () {

		transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);

	}
		
}

