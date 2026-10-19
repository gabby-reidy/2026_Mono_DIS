using UnityEngine;

public class About : MonoBehaviour
{
   public void OnBackClicked()
    {
        Debug.Log("<color=green>OnBackClicked</color>");
        AudioManager.Instance.PlayClick();
        Destroy(gameObject);
    }
}
