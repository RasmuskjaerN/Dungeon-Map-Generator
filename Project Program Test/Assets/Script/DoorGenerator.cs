using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGenerator
{

    public GameObject door;

    
    public static void CreateDoor(HashSet<Vector2Int> roomPos,HashSet<Vector2Int> corridorPos,TilemapVisualizer tilemapVisualizer)
    {
        HashSet<Vector2Int> doorPos = FindDoorFromRoom(roomPos, corridorPos);;
        //FindDoorFromCorridor(doorPos, corridorPos);

        HashSet<Vector2Int> corridorOpening = FindDoorFromCorridor(doorPos, corridorPos);;

        foreach (var position in corridorOpening)
        {
            tilemapVisualizer.PaintSingleDoorTile(position);
        }
        
    }

    public static HashSet<Vector2Int> FindDoorFromRoom(HashSet<Vector2Int> roomPos, HashSet<Vector2Int> corridorPos)
    {

        HashSet<Vector2Int> doorPos = new HashSet<Vector2Int>();
        HashSet<Vector2Int> wallPos = new HashSet<Vector2Int>();
        foreach (Vector2Int position in roomPos)
        {
            foreach (Vector2Int dir in Dir2D.cardinalDirList)
            {
                Vector2Int neighbourPos = position + dir;
                if (roomPos.Contains(neighbourPos) == false)
                    wallPos.Add(neighbourPos);
            }
                
        }

        foreach (var wall in wallPos)
        {
            if (corridorPos.Contains(wall) == true)
                doorPos.Add(wall);
        }

        return doorPos;

        //doorPos now contains all the tiles/positions around a roomPos

        //check for each roomPos, if contatained in corridorPos
        
        
    }

    public static HashSet<Vector2Int> FindDoorFromCorridor(HashSet<Vector2Int> doorPos, HashSet<Vector2Int> corridorPos)
    {
        HashSet<Vector2Int> corridorOpening = new HashSet<Vector2Int>();
        
            foreach (Vector2Int position in corridorPos)
            {
                if (doorPos.Contains(position)!=false)
                {
                    corridorOpening.Add(position);
                    Debug.Log("door position" + corridorOpening);
                }
            }
        
        
        return corridorOpening;
    }
}

