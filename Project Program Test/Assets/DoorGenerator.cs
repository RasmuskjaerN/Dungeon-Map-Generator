using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGenerator : MonoBehaviour
{
    public GameObject Door;

    public static HashSet<Vector2Int> FindDoor(HashSet<Vector2Int> roomPos, HashSet<Vector2Int>corridorPos)
    {
        HashSet<Vector2Int> doorPos = new HashSet<Vector2Int>();
        foreach (Vector2Int position in roomPos)
        {
            foreach (var positionC in corridorPos)
            {
                foreach (Vector2Int dir in Dir2D.cardinalDirList)
                {
                    Vector2Int neighbourPos = position + dir;
                    if (roomPos.Contains(neighbourPos) != true){
                        doorPos.Add(neighbourPos);
                        
                    } else if (corridorPos.Contains(neighbourPos))
                    {
                        doorPos.Add(neighbourPos);
                    }
                    
                        
                    

                }

            }
        }


        return doorPos;

        /* HashSet<Vector2Int> doorPos = new HashSet<Vector2Int>();
         foreach (Vector2Int roomPos in corridorPos)
         {
             foreach (Vector2Int dir in Dir2D.cardinalDirList)
             {
                 Vector2Int neighbourPos = roomPos + dir;
                 if (corridorPos.Contains(neighbourPos) == false)
                     corridorPos.Add(neighbourPos);
             }
         }
         */
    }
    
}
