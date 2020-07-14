﻿using UnityEngine;
using System.Collections;

public static class Constants 
{

    public static readonly int MaxRows = 3;
    public static readonly int MaxColumns = 3;
    public static readonly int MaxSize = MaxRows * MaxColumns;
}

enum GameState
{
    Start,
    Playing,
    Animating,
    End
}
