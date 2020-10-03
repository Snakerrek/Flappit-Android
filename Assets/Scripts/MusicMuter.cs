using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicMuter : MonoBehaviour
{
    [SerializeField] Sprite[] images;
    GameObject musicPlayer;
    AudioSource audioSource;
    Image silencerImage;

    public void ChangeVolume()
    {
        musicPlayer = FindObjectOfType<MusicPlayer>().gameObject;
        audioSource = musicPlayer.GetComponent<AudioSource>();
        silencerImage = GetComponent<Image>();
        if (audioSource.volume == 0)
        {
            silencerImage.sprite = images[0];
            audioSource.volume = 0.25f;
        }
        else
        {
            silencerImage.sprite = images[1];
            audioSource.volume = 0f;
        }
    }


}
