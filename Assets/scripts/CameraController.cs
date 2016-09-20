using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private GameObject ball;
	private Vector3 offset;

	private void Awake () {
		ball = GameObject.FindGameObjectWithTag ("Player");
		offset = ball.transform.position - transform.position;
	}

	private void Update () {
		if (ball.transform.position.y > 0) {
			transform.position = ball.transform.position - offset;
		}
	}
}
