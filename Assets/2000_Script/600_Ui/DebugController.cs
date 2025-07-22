using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugController : MonoBehaviour
{
    public System.Collections.Generic.List<Button> ButtonList = new System.Collections.Generic.List<Button>();


    public void Intialize()
    {
        ButtonList[0].onClick.AddListener(() =>
        {
            AddHpReasonButton();
        });
        ButtonList[1].onClick.AddListener(() =>
        {
            AddHpReasonButton();
        });
        ButtonList[2].onClick.AddListener(() =>
        {
            AddHpReasonButton();
        });
        ButtonList[3].onClick.AddListener(() =>
        {
            AddHpReasonButton();
        });
        ButtonList[4].onClick.AddListener(() =>
        {
            AddHpReasonButton();
        });
        ButtonList[5].onClick.AddListener(() =>
        {
            AddHpReasonButton();
        });
        
    }

    public void Open()
    {

    }

    public void AddHpReasonButton()
    {
        
    }
    public void RemoveAllEnemy()
    {
        var enemyList = new List<Enemy>();

        foreach (var enemy in Manager.Stage.EnemyList)
        {
            enemy.enabled = false;
        }
    }
}
