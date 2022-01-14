using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance {get; private set; }

    private AudioSource source;

    void Awake()
    {
        instance = this;
    }

    public void PlaySound(AudioClip sound)
    {
        source.PlayOneShot(sound);
    }
}