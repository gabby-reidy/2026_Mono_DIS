using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Data (read / write): Holds player information (which can change)
/// at runtime in Front End and InGame
/// </summary>

public class Player : MonoBehaviour
{
    [Header("Setup")]
    public int playerIdx;
    public string playerName;
    public soPlayerTypes soPlayerType;
    public soPlayerPiece soPlayerPiece;
    public Color playerColor;

    public void IncrementPlayerPiece()
    {
        ePlayerPiece piece = soPlayerPiece.playerPiece;
        piece++;
        if (piece == ePlayerPiece.terminator)
        {
            piece = 0;
        }
        soPlayerPiece = GameManager.Instance.so_Ref.playerPieces[(int)piece];
    }

    public void IncrementPlayerType()
    {
        ePlayerType type = soPlayerType.playerType;
        type++;
        if (type == ePlayerType.terminator)
        {
            type = 0;
        }
        soPlayerType = GameManager.Instance.so_Ref.playerTypes[(int)type];
    }
}
