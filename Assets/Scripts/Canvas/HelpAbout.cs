using UnityEngine;

public class HelpAbout : MonoBehaviour
{

    public void OnAboutClicked()
    {
        Debug.Log("<color=green>OnAboutClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasAbout();
    }

    public void OnUAClicked()
    {
        Debug.Log("<color=green>OnUAClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasUA();
    }

    public void OnPrivacyClicked()
    {
        Debug.Log("<color=green>OnPrivacyClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasUA(); // same screen, no need to make additional prefab, but maybe change name at some point
    }

    public void OnDisableSharingClicked()
    {
        Debug.Log("<color=green>OnDisableSharingClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasDisableSharing();
    }

    public void OnOverviewClicked()
    {
        Debug.Log("<color=green>OnOverviewClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasOverview();
    }

    public void OnBackClicked()
    {
        Debug.Log("<color=green>OnBackClicked</color>");
        AudioManager.Instance.PlayClick();
        Destroy(gameObject);
    }
}
