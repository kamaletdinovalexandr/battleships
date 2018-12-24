using Enums;
using UnityEngine;

namespace Managers {
    public class BoardController : MonoBehaviour {
        [SerializeField] private GameObject _cellPrefab;

        private CellView[,] _cellViews;
        private int _boardWidth;
        private int _boardHeight;

        private void Start() {
            _boardWidth = GameManager.Instance.BoardSize;
            _boardHeight = GameManager.Instance.BoardSize;
            _cellViews = new CellView[_boardWidth, _boardHeight];
            InitBoard();
        }

        private void InitBoard() {
            for (var i = 0; i < _boardWidth; i++)
            for (var j = 0; j < _boardHeight; j++) {
                var cell = Instantiate(_cellPrefab, new Vector2(i, j), Quaternion.identity);
                cell.name = "Cell_" + i + "_" + j;
                _cellViews[i, j] = cell.GetComponent<CellView>();
            }
        }

        public void SetCellState(Vector2Int position, CellStatus status) {
            switch (status) {
                case CellStatus.Unknown:
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
}