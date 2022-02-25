using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.UIElements;
using UnityEngine.Tilemaps;

public class TestyTest : MonoBehaviour
{

    [SerializeField] Grid tilemapGrid;
    [SerializeField] Tilemap rockTilemap;
    [SerializeField] Rigidbody2D playerRb;

    void Update()
    {
        GetRockToClick();
        GetPlayerPos();
        ClickOnRock(); // if PlayerInOffset == true && isPickaxe == true
    }

    void GetRockToClick() // tileUnderCursor IS tile/rock MouseHovers 
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousePosNoZ = new Vector3(mousePos.x, mousePos.y);
        Vector3Int mouseTileCell = tilemapGrid.WorldToCell(mousePosNoZ);
        Debug.Log(mouseTileCell); // cursor pos real time 

        TileBase tileUnderCursor = rockTilemap.GetTile(mouseTileCell);
        Debug.Log(tileUnderCursor); // tells you tile under cursor <--- ROCK under CURSOR
    }

    void GetPlayerPos() // playerTileCell IS playerPosRealTime
    {
        Vector3 playerPos = playerRb.transform.position;
        Vector3 playerPosNoZ = new Vector3(playerPos.x, playerPos.y);
        Vector3Int playerTileCell = tilemapGrid.WorldToCell(playerPosNoZ);
        Debug.Log(playerTileCell); //play pos real time (?) <--- PLAYER POS, REAL TIME

        TileBase tileUnderPlayer = rockTilemap.GetTile(playerTileCell);
        Debug.Log(tileUnderPlayer);// tells you tile under player (?)
    }


    

    bool PlayerInOffset(Vector3 pos1, Vector3 pos2, Vector3 comp) // use in ClickOnRock()
    {
        return System.Math.Abs(pos1.x - pos2.x) <= comp.x && System.Math.Abs(pos1.y - pos2.y) <= comp.y;
    }

    void ClickOnRock()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousePosNoZ = new Vector3(mousePos.x, mousePos.y);

        Vector3Int mouseTileCell = tilemapGrid.WorldToCell(mousePosNoZ); // cursor pos real time 
        TileBase tileUnderCursor = rockTilemap.GetTile(mouseTileCell); // Rock under cursor

        Vector3 playerPos = playerRb.transform.position;
        Vector3 playerPosNoZ = new Vector3(playerPos.x, playerPos.y);
        
        Vector3 maxOffset = new Vector3(2f, 2f, 2f);
        //onMouseDown
        // if PlayerInOffset == true && isPickaxe == true

    }


}
