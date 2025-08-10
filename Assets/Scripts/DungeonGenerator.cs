using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    public GameObject[] rooms;
    private List<GameObject> spawnedRooms;
    private int[,] roomPositions = new int[5, 5];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



        int floorSize = Random.Range(5, 10);
        int roomNumber = Random.Range(0, rooms.Length);
        spawnedRooms.Add(rooms[roomNumber]);
        Instantiate(rooms[roomNumber]);
        spawnedRooms = GameObject.FindGameObjectsWithTag("Room").ToList();
        roomPositions[2, 2] = 1;
        for (int i = 1; i < floorSize; i++)
        {
            int roomDir = Random.Range(1, 5);
            int chooseRoom = Random.Range(0, spawnedRooms.Count);
            roomNumber = Random.Range(0, rooms.Length);
            spawnedRooms = GameObject.FindGameObjectsWithTag("Room").ToList();



            while (roomNumber < chooseRoom)
            {
                if (roomDir == 1)
                {

                }
            }
        }


        for (int i = 0; i < roomPositions.GetLength(0); i++)
        {
            for (int j = 0; j < roomPositions.GetLength(1); j++)
            {
                if (roomPositions[i, j] == 1)
                {
                    List<(int x, int y)> freeNeighbors = new List<(int, int)>();

                    // Check up
                    if (i > 0 && roomPositions[i - 1, j] == 0)
                        freeNeighbors.Add((i - 1, j));

                    // Check down
                    if (i < roomPositions.GetLength(0) - 1 && roomPositions[i + 1, j] == 0)
                        freeNeighbors.Add((i + 1, j));

                    // Check left
                    if (j > 0 && roomPositions[i, j - 1] == 0)
                        freeNeighbors.Add((i, j - 1));

                    // Check right
                    if (j < roomPositions.GetLength(1) - 1 && roomPositions[i, j + 1] == 0)
                        freeNeighbors.Add((i, j + 1));

                    if (freeNeighbors.Count > 0)
                    {
                        // Pick random adjacent free slot
                        var chosen = freeNeighbors[Random.Range(0, freeNeighbors.Count)];
                        roomPositions[chosen.x, chosen.y] = 1; // mark as taken
                    }
                }
            }
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
