using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
public class blackout : MonoBehaviour
{
    [SerializeField] private Image image;
    private TweenerCore<Vector3, Vector3, VectorOptions> _tweener;
    [SerializeField] Transform posA;
    [SerializeField] Transform posB;

    [SerializeField] float time = 5f;

    public byte a2;
    private void Update()
    {
        float a1 = transform.position.y * 255;
        a2 = (byte)a1;
        byte a3;
        image.color =  new Color32(0,0,0,a2);
    }

    public void MoveUp()
    {
        _tweener = transform.DOMove(posA.position, time).SetEase(Ease.Linear);
        _tweener.onComplete += MoveDown;
        
    }

    public void MoveDown()
    {
        _tweener = transform.DOMove(posB.position, time).SetEase(Ease.Linear);
        Time.timeScale = 1;
    }

    private void OnDestroy()
    {
        if (_tweener != null)
        {
            _tweener.Kill();
        }
    }
}
