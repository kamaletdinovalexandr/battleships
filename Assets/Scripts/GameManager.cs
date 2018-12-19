using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager Instance { get; set; }
	private IGameState _gameState;
	public int BoardWidth;
	public int BoardHeight;

	private void Awake() {
				if (Instance == null)
						Instance = this;
	}

	public void SetGameState(IGameState newState) {
		_gameState = newState;
	}
}
