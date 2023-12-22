using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _scaleChange;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOScale(_scaleChange, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
