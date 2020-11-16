using System.Collections;
using System.Collections.Generic;
using StateMachine;
using UnityEngine;

public class GameInitState : BaseGameState {
    private GameManager gameManager;
    private CameraManager cameraManager;
    private int[, ] board;
    public GameInitState (StateManager<GameManager> stateManager) : base (stateManager) {
        gameManager = StateManager.Manager;
        cameraManager = gameManager.CameraManager;
    }

    public override void Enter () {
        gameManager.StartCoroutine (InitializeCoroutine ());
    }

    private void InitializeGame () {
        cameraManager.Position = new Vector3 (gameManager.BoardSize.x, gameManager.BoardSize.y) / 2;
        board = new int[gameManager.BoardSize.x, gameManager.BoardSize.y];
        gameManager.Boards = new BoardTile[gameManager.BoardSize.x, gameManager.BoardSize.y];

        for (int i = 0; i < gameManager.BoardSize.x; i++) {
            for (int j = 0; j < gameManager.BoardSize.y; j++) {
                board[i, j] = 0;
                var tile = MonoBehaviour.Instantiate (gameManager.TilePrefab, new Vector3 (i, j), Quaternion.identity, gameManager.transform);
                gameManager.Boards[i, j] = tile;
            }
        }
    }
    private IEnumerator InitializeCoroutine () {
        InitializeGame ();
        yield return null;
    }
}