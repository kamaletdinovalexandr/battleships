using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager Instance { get; set; }
	private IGameState _gameState;
	public int BoardWidth;
	public int BoardHeight;
	private Admiral Player1;
	private Admiral AI;

	private void Awake() {
		if (Instance == null)
			Instance = this;
		
		Player1 = new Admiral {
			Ships = new List<Ship>() { new Ship(1), new Ship(1), new Ship(1), new Ship(1),
									   new Ship(2), new Ship(2), new Ship(2),
									   new Ship(3), new Ship(3),
									   new Ship(4)}
		};
		AI = new Admiral {
			Ships = new List<Ship>() { new Ship(1), new Ship(1), new Ship(1), new Ship(1),
									   new Ship(2), new Ship(2), new Ship(2),
									   new Ship(3), new Ship(3),
									   new Ship(4)}
		};

		SetGameState(new ShipsPlacementState(this));
	}

	private void Update() {
		_gameState.ExecuteState();
	}

	public void SetGameState(IGameState newState) {
		_gameState = newState;
	}
}
