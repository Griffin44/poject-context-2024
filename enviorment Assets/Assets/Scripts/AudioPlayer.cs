using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private List<AudioClip> audioClips = new List<AudioClip>();
    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayClip(int clip) {
        source.PlayOneShot(audioClips[clip]);
    }

    public void PlayRandom() {
        int randomClip = Random.Range(0, audioClips.Count);
        source.PlayOneShot(audioClips[randomClip]);
    }
}
