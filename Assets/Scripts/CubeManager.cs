using System;
using System.Collections.Generic;
using System.Linq;
using MidiJack;
using UnityEngine;

namespace MaschineVisualizer
{
    public class CubeManager : MonoBehaviour
    {
        private List<CubeController> cubeControllers; 
        
        private void Awake()
        {
            cubeControllers = GetComponentsInChildren<CubeController>().ToList();
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            
        }
    }
}