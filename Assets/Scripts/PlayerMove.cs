using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

	public float speed;
	public bool isMove;
	public GameObject particles;
	public GameObject player;
	public int score;
	public Text text;

	private void Start() {
		particles.SetActive(false);
		Application.targetFrameRate = 300;
	}

	private void FixedUpdate() {
		if (isMove)
			transform.Rotate(0, 0, speed);
		else
			transform.Rotate(0, 0, -speed);
	}

	public void Update() {
		text.text = score.ToString();	
	}

	public void OnClickPan() {
		isMove = ! isMove;
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.tag == "Enemy") {
			particles.SetActive(true);

			Debug.Log("hit");
			player.SetActive(false);
			speed = 0;
		}

		if (collision.tag == "Coin") {
			score += 1;
		}
	}
}