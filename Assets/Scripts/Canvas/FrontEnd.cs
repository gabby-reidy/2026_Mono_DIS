using UnityEngine;

/// <summary>
/// Canvas: Input: Main Menu buttons and their functionality
/// </summary>

public class FrontEnd : MonoBehaviour
{
    public void OnPlayNowClicked()
    {
        Debug.Log("<color=green>OnPlayNowClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasSetup();
    }

    public void OnOptionsClicked()
    {
        Debug.Log("<color=green>OnOptionsClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasOptions();
    }

    public void OnHelpAboutClicked()
    {
        Debug.Log("<color=green>OnHelpAboutClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasHelpAbout();
    }

    public void OnGameStatisticsClicked()
    {
        Debug.Log("<color=green>OnGameStatisticsClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasGameStatistics();
    }
}
