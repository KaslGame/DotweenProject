using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float _duration;

    private float _xOffset = 5f;

    private void Start()
    {
        Vector3 targetPosition = new Vector3(transform.position.x + _xOffset, transform.position.y, transform.position.z);
        transform.DOMove(targetPosition, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
