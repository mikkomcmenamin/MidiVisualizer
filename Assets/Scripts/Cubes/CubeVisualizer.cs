using System;
using System.Collections.Generic;
using UnityEngine;

namespace MaschineVisualizer
{
    public enum EDrumType
    {
        Default = Int32.MinValue,
        Kick = 24,
        Kick2 = 23,
        Snare = 26,
        Snare2 = 27,
        HatPedal = 43,
        Hihat = 48,
        SnareSideStick = 30,
        CrashLeft = 62,
        CrashRight = 67,
        Ride = 72, 
        China = 76,
        RackTom = 33,
        FloorTom1 = 37, 
        FloorTom2 = 39
    }
    
    public class CubeVisualizer : MonoBehaviour
    {
        private Dictionary<EDrumType, CubeController> _cubes;

        private void Awake()
        {
            _cubes = new Dictionary<EDrumType, CubeController>();
            
            foreach (var cubeController in GetComponentsInChildren<CubeController>())
            {
                if (!_cubes.ContainsKey(cubeController.DrumType))
                {
                    _cubes.Add(cubeController.DrumType, cubeController);
                }
            }
        }

        public void OnNoteOn(int channelIndex, byte rawKey, byte rawVelocity)
        {
            if (_cubes == null) return;

            if (_cubes.ContainsKey((EDrumType) rawKey))
            {
                _cubes[(EDrumType)rawKey].ActivateCubeFx();
            }

            // _notes[channelIndex,(int)rawKey] = ( (int) rawVelocity ) / (float) numCount;
            // _lastEventTimes[0] = Time.time;
        }
    }
}