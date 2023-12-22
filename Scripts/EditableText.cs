using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class EditableText : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Text _text;
    private Tweener _tweener;

    private void Start()
    {
        _text = GetComponent<Text>();
        _tweener = _text.DOText("������� �����", _duration);
        _text.DOText("�������� �����", _duration).SetRelative().SetDelay(_duration);
        _text.DOText("������� �����", _duration, true, ScrambleMode.All).SetDelay(_duration * 2);
    }
}
