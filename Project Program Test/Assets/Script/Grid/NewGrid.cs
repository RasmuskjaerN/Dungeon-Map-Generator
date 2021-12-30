using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class NewGrid : MonoBehaviour
{
    [SerializeField]
    private int dungeonWidth=20;
    [SerializeField]
    private int dungeonHeight=10;
    [SerializeField]
    private float cellSize=5f;
    [SerializeField] 
    private Vector2Int startPos = Vector2Int.zero;


    private void Start()
    {
        CreateGrid(dungeonWidth, dungeonHeight);
    }


    private void runProceduralGeneration()
    {
       
    }
    
    
    

    public List<Vector2Int> CreateGrid(int dungeonWidth, int dungeonHeight)
    {
        List<Vector2Int> GridList = new List<Vector2Int>();
        GridList.Add(startPos);
        for (int x = 0; x < dungeonWidth; x++)
        {
            for (int y = 0; y < dungeonHeight; y++)
            {
                // UtilsClass.CreateWorldText(gridArray[x, y].ToString(), null, GetWorldPosition(x, y), 30, Color.grey, TextAnchor.MiddleCenter);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.grey, 100f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.grey, 100f);
            }
            
        }
        Debug.DrawLine(GetWorldPosition(0, dungeonHeight), GetWorldPosition(dungeonWidth, dungeonHeight), Color.grey, 100f);
        Debug.DrawLine(GetWorldPosition(dungeonWidth, 0), GetWorldPosition(dungeonWidth, dungeonHeight), Color.grey, 100f);

        return GridList;
    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y)*cellSize;
    }
    
    
 
    
    
    
}
