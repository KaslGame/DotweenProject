using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Color _color;

    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.material.DOColor(_color, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
