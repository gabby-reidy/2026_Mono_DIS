using UnityEngine;

/// <summary>
/// Manager: Handles canvas' and widgets throughout the game
/// </summary> 

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        ShowCanvasFE();
    }

    public void ShowCanvasFE()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasFE"));
    }

    public void ShowCanvasOptions()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasOptions"));
    }

    public void ShowCanvasSetup()
    {
        Setup setup = Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasSetup")).GetComponent<Setup>();
        setup.InitCanvas();
    }

    public void ShowCanvasHelpAbout()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasHelpAbout"));
    }

    public void ShowCanvasAbout()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasAbout"));
    }

    public void ShowCanvasOverview()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasOverview"));
    }

    public void ShowCanvasDisableSharing()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasDisableSharing"));
    }

    public void ShowCanvasUA()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasUA"));
    }

    public void ShowCanvasGameStatistics()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasGameStatistics"));
    }

    public void ShowCanvasReset()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasReset"));
    }

    public void ShowSleightOfHand()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasSleightOfHand"));
    }

    public void ShowCanvasDiceStats()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasDiceStats"));
    }

    public void ShowCanvasDiceInfo()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasDiceInfo"));
    }

    public void ShowCanvasEnvironments()
    {
        Instantiate(Resources.Load<GameObject>("Canvas/" + "CanvasEnvironments"));
    }
}
