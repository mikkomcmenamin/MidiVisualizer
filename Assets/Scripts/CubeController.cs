using System;
using System.Collections;
using MidiJack;
using UnityEngine;

namespace MaschineVisualizer
{
    public class CubeController : MonoBehaviour
    {
        [SerializeField] private int cubeNumber;
        [SerializeField] private int noteNumber;

        private Material cubeMaterial;

        private bool isFlashing;

        private void Awake()
        {
            cubeMaterial = GetComponent<MeshRenderer>().material; 
            cubeMaterial.SetColor("_Color", Color.white);
        }

        private void Update()
        {
            if (MidiMaster.GetKeyDown(noteNumber))
            {
                if(!isFlashing) ActivateCubeFx();
            }
        }

        public void ActivateCubeFx()
        {
            StartCoroutine(FlashColor()); 
        }

        private IEnumerator FlashColor()
        {
            Debug.Log($"Flashing {noteNumber}");
            isFlashing = true; 
            cubeMaterial.SetColor("_Color", Color.magenta);
            yield return new WaitForSeconds(0.07f);
            cubeMaterial.SetColor("_Color", Color.white);
            isFlashing = false;
        }
    }
}