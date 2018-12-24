using Managers;

namespace GameStates {
	public class ShipsBattleState : IGameState {

		private GameManager _gameManager;

		public ShipsBattleState(GameManager gameManager) {
			_gameManager = gameManager;
		}

		public void ExecuteState() {
			throw new System.NotImplementedException();
		}
	}
}

