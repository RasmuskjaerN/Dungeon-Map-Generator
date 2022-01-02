using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------------------------------Credit to Sunny Valley Studio
//--------------------------------https://www.youtube.com/watch?v=-QOCX6SVFsk&list=PLcRSafycjWFenI87z7uZHFv6cUG2Tzu9v
//--------------------------------This youtube tutorial was followed as it fit our vision for the program.
//--------------------------------our own functionality and adaptation has been added by ourselves to fit our scope.

[CreateAssetMenu(fileName = "SimpleRandomWalkParameters_",menuName= "PCG/SimpleRandomWalkData")]//Defines File name that is needed to save parameters.
public class SimpleRandomWalkData : ScriptableObject //Inherites from ScibtableObject to.
{
    public int iterations = 10, walkLength = 10; //Base values from a new saved generation
    public bool startRandomlyEachIteration = true; 

}
