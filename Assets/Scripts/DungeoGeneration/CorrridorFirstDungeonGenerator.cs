using System;
using System.Collections.Generic;
using UnityEngine;

public class CorrridorFirstDungeonGenerator : RandomWalkMapGenerator
{
    [SerializeField]
    private int corridorLength = 14, corridorCount = 5;
    [SerializeField]
    [Range (0.1f,1)]
    private float roomPercent = 0.8f;
    [SerializeField]
    public SimpleRandomWalkSO roomGenerationParameters;
    protected override void RunProceduralGeneration()
    {
        CorridorFirstGeneration();
    }

    private void CorridorFirstGeneration()
    {
        HashSet<Vector2Int> floorPositions = new HashSet<Vector2Int>();
        HashSet<Vector2Int> potentialRoomPosiions = new HashSet<Vector2Int>();

        CreateCorridors(floorPositions, potentialRoomPosiions);

        tileMapVisualizer.PaintFloorTiles(floorPositions);
        WallGenerator.CreateWalls(floorPositions, tileMapVisualizer);
    }

    private void CreateCorridors(HashSet<Vector2Int> floorPositions, HashSet<Vector2Int> potentialRoomPosiions)
    {
        var currentPosition = startPosition;
        potentialRoomPosiions.Add(currentPosition);

        for (int i = 0; i < corridorCount; i++)
        {
            var corridor = DungeonGenerator.RandomWalkCorridor(currentPosition, corridorLength);
            currentPosition = corridor[corridor.Count - 1];
            floorPositions.UnionWith(corridor);
        }
    }
}
