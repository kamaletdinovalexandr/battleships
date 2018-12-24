using System.Collections.Generic;
using GameStates;
using UnityEngine;

namespace Managers {
	public class GameManager : MonoBehaviour {

		public static GameManager Instance { get; private set; }
		private IGameState _gameState;
		public int BoardSize;
		public Admiral Player1;
		public Admiral Ai;

		private void Awake() {
			if (Instance == null)
				Instance = this;
		}
		private void Start() {
			Player1 = new Admiral(this) {
				Ships = new List<Ship>() { new Ship(1), new Ship(1), new Ship(1), new Ship(1),
										   new Ship(2), new Ship(2), new Ship(2),
										   new Ship(3), new Ship(3),
										   new Ship(4)
				}
			};
			Ai = new Admiral(this) {
				Ships = new List<Ship>() { new Ship(1), new Ship(1), new Ship(1), new Ship(1),
										   new Ship(2), new Ship(2), new Ship(2),
										   new Ship(3), new Ship(3),
										   new Ship(4)
				}
			};
			
			SetGameState(new AiPlacementState(this));
			_gameState.ExecuteState();
		}

		public void SetGameState(IGameState newState) {
			_gameState = newState;
		}
	}
}
