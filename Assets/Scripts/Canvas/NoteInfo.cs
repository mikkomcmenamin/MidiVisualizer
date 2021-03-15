using TMPro;
using UnityEngine;

namespace Canvas
{
    public class NoteInfo : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _noteInfoText;
        
        public void OnNoteOn( int channelIndex, byte rawKey, byte rawVelocity )
        {
            var noteText = "NoteOn. ch: " + channelIndex + ", key: " + rawKey + ", vel: " + rawVelocity;
            Debug.Log(noteText);
            _noteInfoText.text = noteText;
        }
    }
}