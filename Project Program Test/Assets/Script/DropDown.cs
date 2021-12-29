using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDown : MonoBehaviour
{
    public SimpleRandomWalkData bigDungeon;
    public SimpleRandomWalkData island;
    public SimpleRandomWalkData mediumDungeon;
    public SimpleRandomWalkData onlyCorridors;
    public SimpleRandomWalkData smallDungeon;
    
    public RoomFirstDungeonGenerator rfdg;
    
    public SimpleRandomWalkDungeonGenerator srwdg;
    
    public CorridorFirstDungeonGeneration cfdg;


    public void Start()
    {
        rfdg = GameObject.Find("RoomsFirstDungeonGenerator").GetComponent<RoomFirstDungeonGenerator>();
        srwdg = GameObject.Find("SimpleRandomWalkDungeonGenerator").GetComponent<SimpleRandomWalkDungeonGenerator>();
        cfdg = GameObject.Find("CorridorFirstDungeonGenerator").GetComponent<CorridorFirstDungeonGeneration>();
        
    
    }
    
    
    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            rfdg.randomWalkParameters = bigDungeon;
            srwdg.randomWalkParameters = bigDungeon;
            cfdg.randomWalkParameters = bigDungeon;
        }

        if (val == 1)
        {
            cfdg.randomWalkParameters = island;
            srwdg.randomWalkParameters = island;
            rfdg.randomWalkParameters = island;
        }

        if (val == 2)
        {
            cfdg.randomWalkParameters = mediumDungeon;
            srwdg.randomWalkParameters = mediumDungeon;
            rfdg.randomWalkParameters = mediumDungeon;
        }

        if (val == 3)
        {
            cfdg.randomWalkParameters = onlyCorridors;
            srwdg.randomWalkParameters = onlyCorridors;
            rfdg.randomWalkParameters = onlyCorridors;
        }

        if (val == 4)
        {
            cfdg.randomWalkParameters = smallDungeon;
            srwdg.randomWalkParameters = smallDungeon;
            rfdg.randomWalkParameters = smallDungeon;
        }
        
    }

}
