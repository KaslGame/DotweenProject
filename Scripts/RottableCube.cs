using DG.Tweening;
using UnityEngine;

public class RottableCube : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 targetPosition;

    private void Start()
    {
        transform.DORotate(targetPosition, _duration, RotateMode.Fast).SetLoops(-1, LoopType.Yoyo);
    }
}
