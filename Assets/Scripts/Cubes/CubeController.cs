using System.Collections;
using UnityEngine;

namespace MaschineVisualizer
{
    public class CubeController : MonoBehaviour
    {
        public EDrumType DrumType => _drumType;
        
        [SerializeField] private EDrumType _drumType;

        [SerializeField] private Material cubeMaterial;
        [SerializeField] private Material cubeMaterialFlash;

        private MeshRenderer _renderer;

        private IEnumerator _flashCoroutine;

        private void Awake()
        {
            _renderer = GetComponent<MeshRenderer>();
            _renderer.material = cubeMaterial;
        }

        public void ActivateCubeFx()
        {
            StartCoroutine(FlashColor());
        }

        private IEnumerator FlashColor()
        {
            _renderer.material = cubeMaterialFlash;
            yield return new WaitForSeconds(0.03f);
            _renderer.material = cubeMaterial;
        }
    }
}