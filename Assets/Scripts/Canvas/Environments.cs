using UnityEngine;
using UnityEngine.UI;

public class Environments : MonoBehaviour
{
    [SerializeField] private Image imageToChange;
    [SerializeField] private Sprite[] environmentSprites;

    public void OnEnvironmentOneClicked()
    {
        imageToChange.sprite = environmentSprites[0];
    }

    public void OnEnvironmentTwoClicked()
    {
        imageToChange.sprite = environmentSprites[1];
    }

    public void OnEnvironmentThreeClicked()
    {
        imageToChange.sprite = environmentSprites[2];
    }

    public void OnEnvironmentFourClicked()
    {
        imageToChange.sprite = environmentSprites[3];
    }

    public void OnEnvironmentFiveClicked()
    {
        imageToChange.sprite = environmentSprites[4];
    }

    public void OnBackClicked()
    {
        Debug.Log("<color=green>OnBackClicked</color>");
        AudioManager.Instance.PlayClick();
        Destroy(gameObject);
    }
}
