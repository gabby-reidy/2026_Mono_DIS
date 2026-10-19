using UnityEngine;

public class Statistics : MonoBehaviour
{
    public void OnResetClicked()
    {
        Debug.Log("<color=green>OnBackClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasReset();
    }

    public void OnDiceStatsClicked()
    {
        Debug.Log("<color=green>OnDiceStatsClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasDiceStats();
    }

    public void OnDiceInfoClicked()
    {
        Debug.Log("<color=green>OnDiceInfoClicked</color>");
        AudioManager.Instance.PlayClick();
        CanvasManager.Instance.ShowCanvasDiceInfo();
    }

    public void OnBackClicked()
    {
        Debug.Log("<color=green>OnBackClicked</color>");
        AudioManager.Instance.PlayClick();
        Destroy(gameObject);
    }
}
