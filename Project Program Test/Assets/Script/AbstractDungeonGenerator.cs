using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractDungeonGenerator : MonoBehaviour //We make abstract class so that we can generate in the editor.
{
    [SerializeField] 
    protected TilemapVisualizer tilemapVisualizer = null; //makes sure all generations have a tilemapVisualizer
    [SerializeField]
    protected Vector2Int startPos = Vector2Int.zero; //every generation has a start position
    /*[SerializeField] protected int dungeonWidth=20;
    [SerializeField] protected int dungeonHeight=10;
    [SerializeField] protected float cellSize=5f;
*/

    public void GenerateDungeon()
    {
        tilemapVisualizer.Clear();
        runProceduralGeneration();
    }

    

    protected abstract void runProceduralGeneration(); //Makes generation possible based on which is picked to generate.
                                                       //Every Generation algorithm/method can be generated
}
