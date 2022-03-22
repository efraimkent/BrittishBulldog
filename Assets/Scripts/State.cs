using System;
using UnityEngine;

[Serializable]
public class State {
    public CellType[,] grid;
    public Vector2Int player;
    public Vector2Int enemy;
    public Vector2Int goal;
}
