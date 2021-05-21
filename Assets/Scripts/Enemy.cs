using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public GameObject[] prefabs;

	private void Start() {
		StartCoroutine(SpawnEnemy());
	}

	private void Repeat() {
		StartCoroutine(SpawnEnemy());
	}

	IEnumerator SpawnEnemy() {
		yield return new WaitForSeconds(2f);
		Instantiate(prefabs[Random.Range(0, 2)], new Vector2(-8, Random.Range(-1.2f, 1.2f)),
			Quaternion.identity);
		Repeat();
	}

}
