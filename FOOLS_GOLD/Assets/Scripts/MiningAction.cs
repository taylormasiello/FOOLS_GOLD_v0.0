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
        SetSearchingCursor(searchingCursor);
        backpackBtn.onClick.AddListener(EquipPickaxe);

    }

    public void SetSearchingCursor(Texture2D texture)
    {
        Cursor.SetCursor(searchingCursor, Vector2.zero, CursorMode.Auto);
    }

    public void SetMiningCursor(Texture2D texture)
    {
        Cursor.SetCursor(miningCursor, Vector2.zero, CursorMode.Auto);
    }

    void EquipPickaxe()
    {
        SetMiningCursor(miningCursor);
        /*gameCursor.GetComponent<GameCursor>().SetMiningCursor(miningCursor)*/;
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (!playerCollider.IsTouchingLayers(LayerMask.GetMask("Mining")))
        {
            return;
        }
        else
        {
            Debug.Log("Kenny is trying to mine");
        }
    }










    // check kenny if is touching rock: rockCompositeCollider2D.IsTouching(playerCapsuleCollider)

    // set to pickaxeCursor: gameCursor.GetComponent<GameCursor>().SetMiningCursor(miningCursor);


}
