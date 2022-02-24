using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningAction : MonoBehaviour
{
    [SerializeField] GameObject gameCursorObject;
    [SerializeField] Texture2D miningCursor;
    [SerializeField] Texture2D searchingCursor;

    [SerializeField] CapsuleCollider2D playerCapsuleCollider;
    [SerializeField] CompositeCollider2D rockCompositeCollider2D;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!playerCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Mining")))
        {
            return;
        }
        else
        {
            gameCursorObject.GetComponent<GameCursor>().SetMiningCursor(miningCursor);

        }
    }

    //void OnMouseEnter()
    //{
    //    if (rockCompositeCollider2D.gameObject.tag == "rock")
    //    {
    //        gameCursorObject.GetComponent<GameCursor>().SetMiningCursor(miningCursor); // <GameCusor> name of other script; SetMiningCursor() method pulled from other script
    //    }
    //}

    //void OnMouseExit()
    //{
    //    if (rockCompositeCollider2D.gameObject.tag == "rock")
    //    {
    //        gameCursorObject.GetComponent<GameCursor>().SetSearchingCursor(searchingCursor);
    //    }
    //}
}
