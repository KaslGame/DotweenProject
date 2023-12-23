using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _scaleChange;
    [SerializeField] private Vector3 targetRotation;
    private float _xOffset = 2f;

    private void Start()
    {
        Vector3 targetPosition = new Vector3(transform.position.x + _xOffset, transform.position.y, transform.position.z);
        transform.DOScale(_scaleChange, _duration).SetLoops(-1, LoopType.Yoyo);
        transform.DOMove(targetPosition, _duration).SetLoops(-1, LoopType.Yoyo);
        transform.DORotate(targetRotation, _duration, RotateMode.Fast).SetLoops(-1, LoopType.Yoyo);
    }
}
