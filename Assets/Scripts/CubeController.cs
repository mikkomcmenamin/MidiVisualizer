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

        [SerializeField]
        private Material cubeMaterial;

        [SerializeField] private Material cubeMaterialFlash;

        private MeshRenderer renderer; 

        private bool isFlashing;

        private void Awake()
        {
            renderer = GetComponent<MeshRenderer>();
            renderer.material = cubeMaterial; 
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
            renderer.material = cubeMaterialFlash;
            yield return new WaitForSeconds(0.07f);
            renderer.material = cubeMaterial; 
            isFlashing = false;
        }
    }
}