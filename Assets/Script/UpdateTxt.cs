using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpdateTxt : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private PlayerData data;
    void Update()
    {
        text.text = data.Money.ToString();
    }
}
