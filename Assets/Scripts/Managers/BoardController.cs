using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour{

	[SerializeField] private GameObject _cellPrefab;

	private CellView[,] _cellViews;
	private int _boardWidth;
	private int _boardHeigth;

	private void Start() {
		_boardWidth = GameManager.Instance.BoardWidth;
		_boardHeigth = GameManager.Instance.BoardHeight;
		_cellViews = new CellView[_boardWidth, _boardHeigth];
		InitBoard();
	}

	private void InitBoard() {
		for (int i = 0; i < _boardWidth; i++)
			for (int j = 0; j < _boardHeigth; j++) {
				var cell = Instantiate(_cellPrefab, new Vector2(i, j), Quaternion.identity);
				cell.name = "Cell_" + i + "_" + j;
				_cellViews[i, j] = cell.GetComponent<CellView>();
			}
	}

	public void SetCellState(Vector2Int position, CellStatus status) {
		switch (status) {
			case CellStatus.Uknown:
				_cellViews[position.x, position.y].SetEmpty();
				break;
			case CellStatus.Missed:
				_cellViews[position.x, position.y].SetMissed();
				break;
			case CellStatus.Destroyed:
				_cellViews[position.x, position.y].SetDestroyed();
				break;
			default:
				break;
		}
	}
}

