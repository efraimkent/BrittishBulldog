using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameView : MonoBehaviour {
    public BoardPiece BoardPiecePrefab;
    List<BoardPiece> boardPieces = new List<BoardPiece>();

    public void UpdateView(State state) {

        // creates boardPieces
        foreach (var boardPiece in this.boardPieces) {
            Destroy(boardPiece);
        }
        boardPieces.Clear();

        // 1: creates grid cells
        for (int x = 0; x < state.gridWidth; x++) {
            for (int y = 0; y < state.gridWidth; y++) {
                // 2: instantiates prefab that only has a sprite (4.2: ...at the correct grid cell)
                var boardPiece = Instantiate(BoardPiecePrefab, new Vector3(x, y), Quaternion.identity);
                // 3: changes sprite colour to green
                boardPiece.sprite.color = Color.green;
                // 4.1: and places the prefab...
                boardPieces.Add(boardPiece);
            }
        }

        // checks player, creates prefab at player position and changes colour to blue
        var player = Instantiate(BoardPiecePrefab, new Vector3(state.player.x, state.player.y, -0.1f), Quaternion.identity);
        player.sprite.color = Color.blue;
        boardPieces.Add(player);

        // checks enemy, creates prefab at enemy position and changes colour to blue
        var enemy = Instantiate(BoardPiecePrefab, new Vector3(state.enemy.x, state.enemy.y, -0.1f), Quaternion.identity);
        enemy.sprite.color = Color.red;
        boardPieces.Add(enemy);

        // checks goal, creates prefab at goal position and changes colour to blue
        var goal = Instantiate(BoardPiecePrefab, new Vector3(state.goal.x, state.goal.y, -0.05f), Quaternion.identity);
        goal.sprite.color = Color.yellow;
        boardPieces.Add(goal);
    }
}
