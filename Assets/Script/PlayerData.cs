using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private const string MONEY = "MONEY";
    private float money;    
    private const string GITARA = "GITARA";
    private int gitara;


    public float Money
    {
        get { return money; }
        set
        {
            money = value;
            PlayerPrefs.SetFloat(MONEY, money);
            PlayerPrefs.Save();
        }
    }
    public int Gitara
    {
        get { return gitara; }
        set
        {
            gitara = value;
            PlayerPrefs.SetInt(GITARA, gitara);
            PlayerPrefs.Save();
        }
    }


    private void Awake()
    {

        money = PlayerPrefs.GetFloat(MONEY, 0);
        gitara = PlayerPrefs.GetInt(GITARA, 0);
    }

    public void addMoney()
    {
        Money += 100;
    }    
    public void minusMoney()
    {
        Money -= 100;
    }     
    public void nullMoney()
    {
        Money = 00;
    }   
    public void BuyGitare()
    {
        if (money >= 100)
        {
            Gitara = 1;
            minusMoney();
        }
    }
    

}
