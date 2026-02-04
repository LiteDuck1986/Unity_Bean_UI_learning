using UnityEngine;

public class SFX_Script : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip[] audioClips;

    public void PlaySFX(int ix)
    {
        if(sfxSource.isPlaying)
            sfxSource.Stop();

        sfxSource.loop = false;
        sfxSource.PlayOneShot(audioClips[ix]);
    }

    public void PlayMusic(int ix)
    {
        if (sfxSource.isPlaying)
            sfxSource.Stop();

        sfxSource.clip = audioClips[ix];
        sfxSource.loop = true;
        sfxSource.Play();
    }
}
