using UnityEngine;

public class HiglightableObject : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;

    [SerializeField] private Color _highlightColor;

    private Material _material;

    private void Awake()
    {
        _material = _meshRenderer.material;
    }

    public void Highlight()
    {
        _material.color = _highlightColor;
    }

    public void Reset()
    {
        _material.color = Color.white;
    }
}