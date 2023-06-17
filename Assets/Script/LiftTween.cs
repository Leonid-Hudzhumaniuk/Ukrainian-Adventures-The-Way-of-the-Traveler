using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;

public class LiftTween : MonoBehaviour
{
    [SerializeField] Transform posA;
    [SerializeField] Transform posB;

    [SerializeField] float time = 5f;
    private TweenerCore<Vector3, Vector3, VectorOptions> _tweener;

    void Start()
    {
        MoveUp();

    }

    private void MoveUp()
    {
        _tweener = transform.DOMove(posB.position, time).SetEase(Ease.InOutQuint);

    }



    private void OnDestroy()
    {
        if (_tweener != null)
        {
            _tweener.Kill();
        }
    }
}
