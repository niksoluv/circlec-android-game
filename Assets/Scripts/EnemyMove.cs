using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	public int speed;

	private void FixedUpdate() {
		transform.Translate(Vector2.right * speed * Time.deltaTime);
	}

}