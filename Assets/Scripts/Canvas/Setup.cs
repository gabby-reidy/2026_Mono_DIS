using UnityEngine;
using UnityEngine.UI;

public class Setup : MonoBehaviour
{
    public RectTransform Group_PlayerButtons;
    public Button buttonPlay;

    public void InitCanvas()
    {
        for (int i = 0; i < PlayerManager.maxPlayers; i++)
        {
            wSetup w_Setup = Instantiate(Resources.Load<GameObject>("Widgets/w_Setup"), Group_PlayerButtons).GetComponent<wSetup>();
            w_Setup.InitWidget(PlayerManager.Instance.players[i]);
        }
    }

    // The play button should be inactive when:
    // 1. There is no human player
    // 2. There is less than 2 players of any type (except none)

    public void CheckForPlayButton()
    {
        int humanPlayers = 0;
        int activePlayers = 0;

        foreach (Player p in PlayerManager.Instance.players)
        {
            if (p.soPlayerType.playerType == ePlayerType.human)
            {
                humanPlayers++;
            }
            if (p.soPlayerType.playerType != ePlayerType.none)
            {
                activePlayers++;
            }
        }

        SetButtonPlay(humanPlayers > 0 && activePlayers > 1);
    }

    void SetButtonPlay (bool _active)
    {
        buttonPlay.interactable = _active;
    }

    public void OnPlayClicked()
    {
        Debug.Log("<color=green>OnPlayClicked</color>");
        AudioManager.Instance.PlayClick();
    }

    public void OnCancelClicked()
    {
        Debug.Log("<color=green>OnCancelClicked</color>");
        AudioManager.Instance.PlayClick();
        Destroy(gameObject);
    }

    // for UI demo
    public void OnInfoClicked()
    {
        Debug.Log("<color=green>OnInfoClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowSleightOfHand();
    }

    public void OnEnvironmentsClicked()
    {
        Debug.Log("<color=green>OnEnvironmentsClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasEnvironments();
    }
}
