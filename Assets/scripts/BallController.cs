using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class BallController : MonoBehaviour {

	[SerializeField]
	private float force = 1;

	private Rigidbody rb;

	private void Awake () {
		rb = GetComponent<Rigidbody> ();
	}

	private void FixedUpdate () {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		rb.AddForce (Vector3.forward * force * h);
		rb.AddForce (Vector3.right * force * -v);

	}
}
