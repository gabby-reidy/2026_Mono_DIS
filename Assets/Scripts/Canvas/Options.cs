using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Canvas: Input: Music and Volume Sliders, controls game options
/// </summary>

public class Options : MonoBehaviour
{
    public Slider MusicSlider;
    public Slider EffectsSlider;

    private void Start()
    {
        MusicSlider.value = AudioManager.Instance.volume[(int)eMixers.Music];
        EffectsSlider.value = AudioManager.Instance.volume[(int)eMixers.Effects];
    }

    public void OnMusicSliderChanged(float _value)
    {
        AudioManager.Instance.SetMixerLevel(eMixers.Music, _value);
    }

    public void OnEffectsSliderChanged(float _value)
    {
        AudioManager.Instance.SetMixerLevel(eMixers.Effects, _value);
    }

    public void OnBackClicked()
    {
        Debug.Log("<color=green>OnBackClicked</color>");
        AudioManager.Instance.PlayClick();
        Destroy(gameObject);
    }

    //temporary for front end demo:
    public void OnButtonClicked()
    {
        Debug.Log("<color=green>OnButtonClicked</color>");
        AudioManager.Instance.PlayClick();
    }
}
