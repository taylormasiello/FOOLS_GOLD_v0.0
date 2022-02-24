using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class MiningAction : MonoBehaviour
{
    [SerializeField] GameObject gameCursor;
    [SerializeField] Button backpackBtn;

    [SerializeField] Texture2D miningCursor;
    [SerializeField] Texture2D searchingCursor;

    [SerializeField] CapsuleCollider2D playerCollider;
    [SerializeField] CompositeCollider2D rockCollider;


    void Start()
    {
        backpackBtn.onClick.AddListener(EquipPickaxe);

    }

    void EquipPickaxe()
    {
        gameCursor.GetComponent<GameCursor>().SetMiningCursor(miningCursor);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!playerCollider.IsTouchingLayers(LayerMask.GetMask("Mining")))
        {
            return;
        }
        else
        {
            Debug.Log("kenny smacks rocks");
        }
    }



    // check kenny if is touching rock: rockCompositeCollider2D.IsTouching(playerCapsuleCollider)

    // set to pickaxeCursor: gameCursor.GetComponent<GameCursor>().SetMiningCursor(miningCursor);


}
