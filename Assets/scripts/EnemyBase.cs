using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    
    public virtual void AttackPlayer()
    {
        TextMeshPro obj = GameObject.Find("Text").GetComponent<TextMeshPro>();
        obj.SetText(gameObject.name + " is attacking the player");
    }

    public virtual void OnMouseOver()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        AttackPlayer();
    }
    public virtual void OnMouseExit()
    {
        TextMeshPro obj = GameObject.Find("Text").GetComponent<TextMeshPro>();
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        obj.SetText("");
    }
}
