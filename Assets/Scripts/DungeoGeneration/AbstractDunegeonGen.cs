using System;
using UnityEngine;

public abstract class AbstractDunegeonGen : MonoBehaviour
{
    [SerializeField]
    protected TileMapVisualizer tileMapVisualizer = null;
    [SerializeField]
    protected Vector2Int startPosition = Vector2Int.zero;

    public void GenerateDungeon()
    {
        tileMapVisualizer.Clear();
        RunProceduralGeneration();

    }

    public void ClearDungeon()
    {
        tileMapVisualizer.Clear();
    }

    protected abstract void RunProceduralGeneration();
    
}
