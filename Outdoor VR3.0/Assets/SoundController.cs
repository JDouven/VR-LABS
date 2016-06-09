using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour
{
    public AudioClip positive, negative;
    private AudioSource audioSource;


    public void OnEnable()
    {
        audioSource.clip = positive;
        audioSource.Play();

    }

    public void OnDisable()
    {
        audioSource.clip = negative;
        audioSource.Play();
    }

    public void Awake()
    {
        audioSource = GetComponentInParent<AudioSource>();
    }
}
