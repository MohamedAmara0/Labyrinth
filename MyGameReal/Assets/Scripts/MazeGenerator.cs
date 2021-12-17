using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Flags]
public enum WallState
{
    // binary structure
    // 0000 -> NO WALLS
    // 1111 -> LEFT, RIGHT, UP, DOWN
    LEFT = 1, // 0001
    RIGHT = 2, // 0010
    UP = 4, // 0100
    DOWN = 8, // 1000
    
}

public static class MazeGenerator
{
    public static WallState[,] Generate(int width, int height)
    {
        WallState[,] maze = new WallState[width, height];
        WallState intial = WallState.RIGHT | WallState.LEFT | WallState.UP | WallState.DOWN;
        for (int i = 0; i < width; ++i)
        {
            for(int j  = 0; j< height; ++j)
            {
                maze[i, j] = intial;    // 1111
            }
        }

        return maze;
    }
} 
/*
public class MazeGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WallState wallState = WallState.LEFT | WallState.RIGHT; // 0011
        wallState |= WallState.UP; // 0111
        wallState &= ~WallState.RIGHT; // 0101

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
