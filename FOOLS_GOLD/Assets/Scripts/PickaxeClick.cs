using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class PickaxeClick : MonoBehaviour
{

    [SerializeField] Grid tilemapGrid;
    [SerializeField] Tilemap rockTilemap;
    //[SerializeField] Tile rockTile;

    [SerializeField] CapsuleCollider2D playerCollider;

    //Vector3Int previousMousePos = new Vector3Int();

    //void Start()
    //{
    //    tilemapGrid = gameObject.GetComponent<Grid>();
    //}

    void Update()
    {
        Vector3Int mousePos = GetMousePos();
                
        if (Input.GetMouseButtonDown(0) && playerCollider.IsTouchingLayers(LayerMask.GetMask("Mining")))
        {
            //rockTilemap.DeleteCells(mousePos, 1, 1, 1);
            Debug.Log(rockTilemap.GetColliderType(mousePos)); // gives "sprite" for rocks, "none" for player & walls
                                                             // only fires when kenny is touching ANY gold (needs to be THAT gold)
        }
        
    }

    Vector3Int GetMousePos()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return tilemapGrid.WorldToCell(mouseWorldPos);
    }

    //void GetRockTileCollider()
    //{
    //    Vector3Int mousePos = GetMousePos();

    //    Debug.Log(rockTilemap.GetColliderType(mousePos));
    //}


    // tilemap obj: .DelectCells (instead of Destory.obj ?)
}
