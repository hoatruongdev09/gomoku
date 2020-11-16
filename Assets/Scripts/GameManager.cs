using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public Vector2Int BoardSize { get => boardSize; }
    public BoardTile TilePrefab { get => boardTilePrefab; }
    public BoardTile[, ] Boards { get => boards; set => boards = value; }
    public CameraManager CameraManager { get => cameraManager; }
    public GameType CurrentGameType { get => gameType; }

    [SerializeField] private CameraManager cameraManager;
    [SerializeField] private Vector2Int boardSize = new Vector2Int (15, 15);
    [SerializeField] private BoardTile boardTilePrefab;
    [SerializeField] private GameType gameType;
    private BoardTile[, ] boards;
    private GameStateManager stateManager;

    private void Start () {
        stateManager = new GameStateManager (this);
        stateManager.Machine.Start (stateManager.GameInitState);
    }
    private void Update () {
        stateManager?.Machine?.CurrentState?.Update ();
    }
}