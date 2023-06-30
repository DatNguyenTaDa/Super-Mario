using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Coin Location Lock
public class BlockCoin : MonoBehaviour {
	private LevelManager t_LevelManager;

	// Use this for initialization
	void Start () {
		t_LevelManager = FindObjectOfType<LevelManager> ();
		t_LevelManager.AddCoin (transform.position + Vector3.down);
	}

}
