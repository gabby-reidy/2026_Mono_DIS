using UnityEngine;

/// <summary>
/// Data (read only): Holds info for all player pieces
/// </summary>

public enum ePlayerPiece { battleship, car, cat, dog, hat, shoe, thimble, wheelbarrow, terminator }

[CreateAssetMenu(fileName = "soPlayerPiece", menuName = "Scriptable Objects/Create Player Piece")]
public class soPlayerPiece : ScriptableObject
{
    public ePlayerPiece playerPiece;
    public string playerPieceName;
    public Sprite playerPieceArt;
}
