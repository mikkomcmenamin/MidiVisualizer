using System.Collections;
using System.Collections.Generic;
using MidiJack;
using UnityEngine;

//    MidiMaster.GetKey (channel, noteNumber)
//
//    Returns the velocity value while the key is pressed, or zero while the key is released. The value ranges from 0.0 (note-off) to 1.0 (maximum velocity).
//
//    MidiMaster.GetKeyDown (channel, noteNumber)
//
//    Returns true during the frame the user starts pressing down the key.
//
//    MidiMaster.GetKeyUp (channel, noteNumber)
//
//    Returns true during the frame the user releases the key.
//
//    MidiMaster.GetKnob (channel, knobNumber, defaultValue)
//
//    Returns the controller value (CC). The value ranges from 0.0 to 1.0.
//
//    MidiMaster.GetKnobNumbers (channel)
//
//    Returns the list of active controllers.

namespace MaschineVisualizer
{
    public class MidiInput : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (MidiMaster.GetKeyDown(36))
            {
                Debug.Log($"Note C0 pressed");
            }

            if (MidiMaster.GetKey(36) > 0)
            {
                Debug.Log("Ceetä paineltu");
            }

            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("nonii space painettu");
            }

            var a = MidiDriver.Instance.GetKey(MidiChannel.Ch1, 24);

            if (a > 0)
            {
                Debug.Log(a);
            }
            
        }
    }
}