//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Tilemaps;
//using UnityEngine.UIElements;

//public class PickaxeClick : MonoBehaviour
//{

//    [SerializeField] Grid tilemapGrid;
//    [SerializeField] Tilemap rockTilemap;
//    [SerializeField] CapsuleCollider2D playerCollider;
//    [SerializeField] GameObject player;
//    [SerializeField] ITilemap rockTileInfo;

//    TileBase rockTile;
//    TileData thisRockTile;


//    void Update()
//    {
//        Vector3Int currentMousePos = GetMousePos();
//        //rockTile = (Tile)rockTilemap.GetTile(currentMousePos);

//        Collider2D rockCollider = rockTilemap.GetComponent<Collider2D>();

//        Vector2 playerPos = player.transform.position;
//        //Vector2 rockWorldPos = rockTile.GetTileData(currentMousePos);

//        Vector3Int playerTilePos = rockTilemap.WorldToCell(playerPos);

//        Vector3Int rockTilePos = 
            
//        rockTilemap.GetTile<TileBase>(playerTilePos);

//        //if (playerTilePos == rockTilePos)
//        //{

//        //}

//        public override void GetTileData

//        if (Input.GetMouseButtonDown(0))
//        {
//            //rockTilemap.DeleteCells(mousePos, 1, 1, 1);
//            // gives "sprite" for rocks, "none" for player & walls, only fires when kenny is touching ANY gold (needs to be THAT gold)

//            //this.rockTile.GetTileData(currentMousePos, rockTilemap, thisRockTile);
//        }
        
//    }

//    void OnTriggerStay2D(Collider2D collision)
//    {
//        if (playerCollider.IsTouchingLayers(LayerMask.GetMask("Mining")))
//        {
//            return;
//        }
//        else
//        {
//            Debug.Log("triggerStay");
//        }
//    }

//    Vector3Int GetMousePos()
//    {
//        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//        return tilemapGrid.WorldToCell(mouseWorldPos);
//    }

//}
