using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {

	[SerializeField] private Camera _camera;
	[SerializeField] private GameObject _cellPrefab;
	[SerializeField] private int _boardWith;
	[SerializeField] private int _boardHeight;
	private Cell[,] _cells;

	private bool _isCellSelected;
	private Vector2Int _currentlySelected;

	private void Start() {
		_cells = new Cell[_boardWith, _boardHeight];
		for (int i = 0; i < _boardWith; i++)
		for (int j = 0; j < _boardHeight; j++) {
			var cell = Instantiate(_cellPrefab, new Vector2(i, j), Quaternion.identity);
			cell.name = "Cell_" + i + "_" + j;
			_cells[i, j] = cell.GetComponent<Cell>();
		}
	}

	private void Update() {
		if (Input.GetMouseButton(0)) {
			Vector2 rayPos = _camera.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);
			if (hit) {
				Transform objectHit = hit.transform;
			
				if (!_isCellSelected) {
					_isCellSelected = true;
					_currentlySelected = new Vector2Int((int)objectHit.position.x, (int)objectHit.position.y);
					_cells[_currentlySelected.x, _currentlySelected.y].ToggleSelection((true));

				}
				else if (_isCellSelected) {
					_cells[_currentlySelected.x, _currentlySelected.y].ToggleSelection((false));
					_currentlySelected = new Vector2Int((int)objectHit.position.x, (int)objectHit.position.y);
					_cells[_currentlySelected.x, _currentlySelected.y].ToggleSelection((true));
				}
					
			
			}
		}
	}
}
