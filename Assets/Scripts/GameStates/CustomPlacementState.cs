using Managers;

namespace GameStates {
	public class CustomPlacementState : IGameState {

		private GameManager _gameManager;

		public CustomPlacementState(GameManager gameManager) {
			_gameManager = gameManager;
		}

		public void ExecuteState() {
			throw new System.NotImplementedException();
		}
	}
}

