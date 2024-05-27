using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;

    [Header("Audio Clip")]
    public AudioClip MainMenuSong;
    public AudioClip PopUpSFX;

    private void Start()
    {
        Invoke("playBGM", 1.3f);
        
    }

    public void playBGM()
    {
        musicSource.clip = MainMenuSong;
        musicSource.Play();
    }

    public void PlayPopUpSFX()
    {
        musicSource.clip = PopUpSFX;
        musicSource.Play();
    }
}
