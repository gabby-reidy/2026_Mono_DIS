using UnityEngine;

/// <summary>
/// Manager: Handles player methods, both creation and access to all of the players
/// </summary>

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;
    public const int maxPlayers = 4;

    public Player[] players;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        CreatePlayers(); // TODO: remove once scenemgr is implemented
    }

    public void CreatePlayers()
    {
        players = new Player[maxPlayers];
        for (int i = 0; i < maxPlayers; i++)
        {
            players[i] = new GameObject("Player " + (i+1)).AddComponent<Player>();
            players[i].transform.SetParent(transform);
            players[i].playerName = "Player " + (i + 1);
            players[i].playerIdx = i;
            players[i].soPlayerPiece = GameManager.Instance.so_Ref.playerPieces[i];
            players[i].soPlayerType = GameManager.Instance.so_Ref.playerTypes[(int)ePlayerType.none];
            players[i].playerColor = GameManager.Instance.so_Ref.playerColors[i];
        }
        players[0].soPlayerType = GameManager.Instance.so_Ref.playerTypes[(int)ePlayerType.human];
        players[1].soPlayerType = GameManager.Instance.so_Ref.playerTypes[(int)ePlayerType.AI];
    }

    public bool CheckForDupePieces(int _playerIdx)
    {
        for (int i = 0; i < players.Length; i++)
        {
            //exclude the player associated with plrindx; exclude the nones
            if (i != _playerIdx && players[i].soPlayerType.playerType != ePlayerType.none)
            {
                //Test for the piece being the same as the player's piece that we sent (_playerIdx)
                if (players[i].soPlayerPiece.playerPiece == players[_playerIdx].soPlayerPiece.playerPiece)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
