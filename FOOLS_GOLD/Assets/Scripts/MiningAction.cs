using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningAction : MonoBehaviour
{
    [SerializeField] GameObject gameCursor;
    [SerializeField] GameObject backpack;

    [SerializeField] Texture2D miningCursor;
    [SerializeField] Texture2D searchingCursor;

    [SerializeField] CapsuleCollider2D playerCapsuleCollider;
    [SerializeField] CompositeCollider2D rockCompositeCollider2D;

    //Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!playerCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Mining")))
        {
            return;
        }
        else
        {
            Debug.Log("Kenny is trying to mine");
        }
    }

    //void Start()
    //{
    //    Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //}

    void Update()
    {
        
        EquipPickaxe();
    }

    public void EquipPickaxe()
    {
        //Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) /*&& cursorPosition == backpack.transform.position*/)
        {
            Debug.Log("Backpack Accessed! Grab your pickaxe...");
        }
        
    }

    // set to pickaxeCursor: gameCursor.GetComponent<GameCursor>().SetMiningCursor(miningCursor);


    //void OnCollisionExit(Collision collision)
    //{
    //    gameCursorObject.GetComponent<GameCursor>().SetSearchingCursor(searchingCursor);
    //}

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
