using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource _audioSource;

    [SerializeField] private AudioClip _landerDeath;
    private static AudioManager _instance;
    public static AudioManager Instance => _instance;

    private void Awake()
    {
        if (_instance != null)
        {
            Debug.LogWarning($"AudioManager already exists, disabling.");
            enabled = false;
            return;
        }

        _instance = this;
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayDeathSound()
    {
        _audioSource.PlayOneShot(_landerDeath);
    }
}
