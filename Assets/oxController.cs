using UnityEngine;
using System.Collections;

public class oxController : MonoBehaviour {

	public Transform cameraFollowing;
	private Vector3 up = new Vector3 (0, 0, 0.5f);
	private Vector3 down = new Vector3 (0, 0, -0.5f);
	private Vector3 left = new Vector3 (-0.5f, 0, 0);
	private Vector3 right = new Vector3 (0.5f, 0, 0);

	private Vector3 jump = new Vector3 (0, 0.5f, 0);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("MoveUp")) {
			this.transform.position = this.transform.position + up;
			cameraFollowing.position = cameraFollowing.position + up;
		}if (Input.GetButton ("MoveDown")) {
			this.transform.position = this.transform.position + down;
			cameraFollowing.position = cameraFollowing.position + down;
		}if (Input.GetButton ("MoveLeft")) {
			this.transform.position = this.transform.position + left;
			cameraFollowing.position = cameraFollowing.position + left;
		}if (Input.GetButton ("MoveRight")) {
			this.transform.position = this.transform.position + right;
			cameraFollowing.position = cameraFollowing.position + right;
		}if (Input.GetButton ("Jump")) {
			this.transform.position = this.transform.position + jump;
		}
	}
}
