using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


//--------------------------------Credit to Sunny Valley Studio
//--------------------------------https://www.youtube.com/watch?v=-QOCX6SVFsk&list=PLcRSafycjWFenI87z7uZHFv6cUG2Tzu9v
//--------------------------------This youtube tutorial was followed as it fit our vision for the program.
//--------------------------------our own functionality and adaptation has been added by ourselves to fit our scope.
public class TilemapVisualizer : MonoBehaviour
{
    [SerializeField]
    private Tilemap floorTilemap/*,wallTilemap*/; //makes tilemaps selectable in unity
    [SerializeField]
    private TileBase floorTile,doorTile,roomTile,corridorTile /*,wallTop*/; //makes tiles selectable.

    

    public void paintRoomTiles(IEnumerable<Vector2Int> roomPos) //IEnumberable is a Generic which makes the tiles loopable.
    {
        PaintTiles(roomPos, floorTilemap, roomTile);
    }
    
    public void paintCorridorTiles(IEnumerable<Vector2Int> corridorPos) //IEnumberable is a Generic which makes the tiles loopable.
    {
        PaintTiles(corridorPos, floorTilemap, corridorTile);
    }

    private void PaintTiles(IEnumerable<Vector2Int> positions, Tilemap tilemap, TileBase tile) //Take in Tiles and its properties.
    {
        List<Vector2Int> iTile = new List<Vector2Int>();
        foreach (var position in positions)
        {
            paintSingleTile(tilemap,tile,position); //Assign the selected tile texture to the tilemap from given position and map.
            iTile.Add(position);
        }

        for (int i = 0; i < iTile.Count; i++)
        {
            Debug.Log("Position: " + iTile[i] + " Index: " + i);
        }
    }

    private void paintSingleTile(Tilemap tilemap, TileBase tile, Vector2Int position) //Assign the Texture the the referenced tile. 
    {
        var tilePos = tilemap.WorldToCell((Vector3Int) position); // Take the position of the tile. World position is the position in the program
        
        // and make it comparable to the position of the tile.
        //tilemap.cellSize.Set(5,5,0);
        tilemap.SetTile(tilePos, tile);
        
    }
    
    /*
     corridorsTile
     doorsTile
     floor
     */
    public void PaintSingleDoorTile(Vector2Int position)
     
    {
        paintSingleTile(floorTilemap,doorTile,position);
    }
    
    
    /*public void PaintSingleBasicWall(Vector2Int position)
    {
        paintSingleTile(wallTilemap,wallTop,position);
    }*/
    /*public void PaintSingleDoorTile(Vector2Int position)
     
    {
        paintSingleTile(floorTilemap,DoorTile,doorPos);
    }*/
    /*public void PaintSingleDoorTile(Vector2Int position)
     
    {
        paintSingleTile(floorTilemap,corridorTile, roomPos);
    }*/

    //I think its possible to use 1 tilemap and have the positions to define what kind of tile it is.
    //Consider if statements to check what type of tile to use.
    
    public void Clear() // makes sure it generates a new generated map.
    {
        floorTilemap.ClearAllTiles();
        //wallTilemap.ClearAllTiles();
    }

    
}
