using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class wSetup : MonoBehaviour
{
    public GameObject buttonAddPlayer;
    public GameObject Group_PlayerButtons;

    [Tooltip("Drag the objects that need to change to player color into this array")]
    public Image[] buttonsToChangeColor;

    public Image imagePiece;
    public TMP_Text textPiece;
    public Image imageType;
    public TMP_Text textType;

    private Player player;

    public void InitWidget(Player _player)
    {
        player = _player;
        ShowButton();
        SetColor();
    }
    
    void ShowButton()
    {
        imagePiece.sprite = player.soPlayerPiece.playerPieceArt;
        textPiece.text = player.soPlayerPiece.playerPieceName;

        imageType.sprite = player.soPlayerType.playerTypeArt;
        textType.text = player.soPlayerType.playerTypeName;
        
        buttonAddPlayer.SetActive(player.soPlayerType.playerType == ePlayerType.none);
        Group_PlayerButtons.SetActive(player.soPlayerType.playerType != ePlayerType.none);
    }

    public void OnPieceClicked()
    {
        Debug.Log("<color=green>OnPieceClicked</color>");
        AudioManager.Instance.PlayClick();
        player.IncrementPlayerPiece();
        ShowButton();
        // Check for dupe piece
        if (PlayerManager.Instance.CheckForDupePieces(player.playerIdx))
        {
            OnPieceClicked();
        }
    }

    public void OnTypeClicked()
    {
        Debug.Log("<color=green>OnTypeClicked</color>");
        AudioManager.Instance.PlayClick();
        player.IncrementPlayerType();
        ShowButton();
        GetComponentInParent<Setup>().CheckForPlayButton();
        // Check for dupe piece
        if (PlayerManager.Instance.CheckForDupePieces(player.playerIdx))
        {
            OnPieceClicked();
        }
    }


    void SetColor()
    {
        foreach (Image i in buttonsToChangeColor)
        {
            i.color = player.playerColor;
        }
    }
}
