using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineAction : MonoBehaviour
{
    [SerializeField] CapsuleCollider2D capsuleCollider;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!capsuleCollider.IsTouchingLayers(LayerMask.GetMask("Mining"))) 
        {
            return;
        }
        else
        {
            Debug.Log("Kenny is trying to mine");
        }

        
    }
}
