using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship {

	public int Size { get; private set; }
	public Direction Direction { get; private set; }
	public ShipStatus ShipStatus { get; set; }
	public List<Vector2Int> FilledCells { get; set; }

	public Ship(int size) {
		Size = size;
		ShipStatus = ShipStatus.Healthy;
	}

	public bool IsShipPlaced() {
		return FilledCells == null;
	}
}
