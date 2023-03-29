using UnityEngine;

public class PlayStopAudio : MonoBehaviour
{
    public AudioSource audioSound;
    bool playing;

    void Start()
    {
        playing = false;
        audioSound = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        if (!playing)
        {
            audioSound.Play(0);
            playing = true;
        }
    }

    public void StopAudio()
    {
        if (playing)
        {
            audioSound.Pause();
            playing = false;
        }
    }

}
