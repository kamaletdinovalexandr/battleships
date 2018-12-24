using Managers;

namespace GameStates {
	public class AiPlacementState : IGameState {
		private readonly GameManager _gameManager;

		public AiPlacementState(GameManager gameManager) {
			_gameManager = gameManager;
		}

		public void ExecuteState() {
			_gameManager.Ai.PlaceShips();
		}
	}
}