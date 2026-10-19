using UnityEngine;
using System;

/// <summary>
/// Manager: handles the game objects that travel from scene to scene
/// </summary>

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public soRef so_Ref;

    private void Awake()
    {
        Instance = this;
        //TODO: dont destroy on load
    }

    private void Start()
    {
        Debug.Log("<color=yellow>Starting Game</color>");
    }
}
