using System.Collections;
using System.Collections.Generic;
using Enums;
using Managers;
using UnityEngine;

public class Admiral {
	
	public List<Ship> Ships { get; set; }
	private bool[,] _field;
	private readonly GameManager _gameManager;

	public Admiral(GameManager gameManager) {
		_gameManager = gameManager;
		_field = new bool[_gameManager.BoardSize, _gameManager.BoardSize];
	}
	
	public void PlaceShips() {
		Vector2Int position;
		ShipDirection direction;
		foreach (var ship in Ships) {
			do {
				position = RandomProvider.GetRandomPosition(_gameManager.BoardSize);
				direction = RandomProvider.GetRandomDirection();
				
			} while (IsPlacementAvailable(ship.Size, position, direction));
			
		}
	}

	private bool IsPlacementAvailable(int size, Vector2Int position, ShipDirection direction) {
		return _field[position.x, position.y] == false;
	}
}
