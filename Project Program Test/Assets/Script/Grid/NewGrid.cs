using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEditor;
using UnityEngine.UI;
using static UnityEngine.UI.GridLayoutGroup;


public class NewGrid : NewGridRandomWalk
{
    

    private Vector3 originPosition;


    private void Start()
    {
        CreateGrid(startPos,dungeonWidth, dungeonHeight);
    }

    private void runProceduralGeneration()
    {
        CreateGrid(startPos,dungeonWidth, dungeonHeight);
    }
    
    
    

    public List<Vector2Int> CreateGrid(Vector2Int GridStartPos ,int gridWidth, int gridHeight)
    {
        gridHeight = dungeonHeight;
        gridWidth = dungeonWidth;
        GridStartPos = startPos;
        
        
        List<Vector2Int> GridList = new List<Vector2Int>();
        List<Vector2Int> GridPath = new List<Vector2Int>();

        GridPath.Add(GridStartPos);
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                var nextGridPoint = new Vector2Int(x, y);
                Debug.DrawLine(GetWorldPosition(x, y),GetWorldPosition(x,y + 1), Color.grey,1000f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x+1, y), Color.grey,1000f);
                Debug.Log("Lastest point "+nextGridPoint);
                //Debug.Log("GridList Contains: " + GridList[x] + "Index: " +x);
                
            }

            //var GridPath = Vector2Int(pathX + pathY);
        }
        
        Debug.DrawLine(GetWorldPosition(0, dungeonHeight), GetWorldPosition(dungeonWidth, dungeonHeight), Color.grey, 100f);
        Debug.DrawLine(GetWorldPosition(dungeonWidth, 0), GetWorldPosition(dungeonWidth, dungeonHeight), Color.grey, 100f);
        
        return GridList;
        
    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        originPosition = new Vector3(startPos.x, startPos.y, 0);
        return new Vector3(x, y)*cellSize+originPosition;
    }

    private void GetXY(Vector3 worldPosition, out int x, out int y)
    {
        x = Mathf.FloorToInt((worldPosition - originPosition).x / cellSize);
        y = Mathf.FloorToInt((worldPosition - originPosition).y / cellSize);
    }






}
