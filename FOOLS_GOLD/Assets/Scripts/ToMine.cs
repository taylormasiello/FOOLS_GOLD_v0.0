using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.UIElements;
using UnityEngine.Tilemaps;

public class ToMine : MonoBehaviour
{
    [SerializeField] Grid tilemapGrid;
    [SerializeField] Tilemap rockTilemap;
    [SerializeField] Rigidbody2D playerRb;
    [SerializeField] GameCursor gameCursor;
    [SerializeField] Vector3 maxOffset = new Vector3(2f, 2f, 2f);

    void Update()
    {
        ClickOnRock();
    }

    bool PlayerInOffset(Vector3 pos1, Vector3 pos2, Vector3 offset) // compares cursor pos world & player pos world to offset
    {
        return System.Math.Abs(pos1.x - pos2.x) <= offset.x && System.Math.Abs(pos1.y - pos2.y) <= offset.y;
    }

    bool ComparedTilesInOffset(Vector3 tile1Pos, Vector3 tile2Pos, Vector3 offset) // offset value is per tile
    {
        return (tile1Pos.x - tile2Pos.x) <= offset.x && (tile1Pos.y - tile2Pos.y) <= offset.y;
    }

    void ClickOnRock()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousePosNoZ = new Vector3(mousePos.x, mousePos.y);// cursor pos, world

        Vector3Int mouseTileCell = tilemapGrid.WorldToCell(mousePosNoZ); // cursor pos, cell
        TileBase tileUnderCursor = rockTilemap.GetTile(mouseTileCell); // Rock under cursor       

        Vector3 playerPos = playerRb.transform.position;
        Vector3 playerPosNoZ = new Vector3(playerPos.x, playerPos.y); //player pos, world

        Vector3Int playerTileCell = tilemapGrid.WorldToCell(playerPosNoZ); //player pos, cell
        TileBase tileUnderPlayer = rockTilemap.GetTile(playerTileCell); //tile under player

        if (PlayerInOffset(mousePosNoZ, playerPosNoZ, maxOffset) && ComparedTilesInOffset(mouseTileCell, playerTileCell, maxOffset) && gameCursor.isPickaxe == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //placeholder; write "MiningAction" script to combine/attach to this "ToMine" script
                Debug.Log("Kenny Can Mine!");
            }
        }
    }
}
