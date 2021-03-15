using UnityEngine;

namespace Audio
{
    public class AudioController : MonoBehaviour
    {
        private AudioSource _audioSource;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
            
            _audioSource.PlayDelayed(0.7f);
        }
        
    }
}