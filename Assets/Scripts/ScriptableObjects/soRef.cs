using UnityEngine;

/// <summary>
/// Data (read only): Central storage area to reference other SOs, player colors, audio effects, etc.
/// </summary>

[CreateAssetMenu(fileName = "New Ref", menuName = "Scriptable Objects/Create Ref")]
public class soRef : ScriptableObject
{
    [NamedArray(typeof(ePlayerPiece))] public soPlayerPiece[] playerPieces;
    [NamedArray(typeof(ePlayerType))] public soPlayerTypes[] playerTypes;
    public Color[] playerColors;
}
