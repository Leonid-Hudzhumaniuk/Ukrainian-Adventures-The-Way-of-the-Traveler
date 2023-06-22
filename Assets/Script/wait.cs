using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
public class wait : MonoBehaviour
{
    private TweenerCore<Vector3, Vector3, VectorOptions> _tweener;
    [SerializeField] Transform posA;
    [SerializeField] Transform posB;
    [SerializeField] float time = 5f;
    [SerializeField] LiftTween bc;

    private void Start()
    {
        MoveUp();
    }

    private void Update()
    {
        if (transform.position.y == 1)
        {
            bc.MoveUp();
        }
    }

    public void MoveUp()
    {
        _tweener = transform.DOMove(posA.position, time).SetEase(Ease.Linear);
        _tweener.onComplete += MoveDown;
        
    }

    public void MoveDown()
    {
        _tweener = transform.DOMove(posB.position, time).SetEase(Ease.Linear);
    }
}
