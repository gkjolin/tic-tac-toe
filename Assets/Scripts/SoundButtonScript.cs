using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

/// <summary>
/// Changes volume status of a specified audio source.
/// </summary>
public class SoundButtonScript : MonoBehaviour {

    public AudioSource audioSource;

    public Sprite soundOn, soundOff;

    private Image curImage;

    private void Awake()
    {
        curImage = GetComponent<Image>();
    }

    public void ChangeVolumeState()
    {
        audioSource.mute = !audioSource.mute;

        if (audioSource.mute) curImage.sprite = soundOff;
        else curImage.sprite = soundOn;
    }
}
