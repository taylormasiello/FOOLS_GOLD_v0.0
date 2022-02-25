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
    //void GetRockToClick() // tileUnderCursor IS tile/rock MouseHovers 
    //{
    //    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    Vector3 mousePosNoZ = new Vector3(mousePos.x, mousePos.y); //cursor real time, 2D world
    //    Vector3Int mouseTileCell = tilemapGrid.WorldToCell(mousePosNoZ);
    //    Debug.Log(mouseTileCell); // cursor pos real time, cell 

    //    TileBase tileUnderCursor = rockTilemap.GetTile(mouseTileCell);
    //    Debug.Log(tileUnderCursor); // tells you tile under cursor <--- ROCK under CURSOR
    //}

    //void GetPlayerPos() // playerTileCell IS playerPosRealTime
    //{
    //    Vector3 playerPos = playerRb.transform.position;
    //    Vector3 playerPosNoZ = new Vector3(playerPos.x, playerPos.y); //playerpos real time, 2D world
    //    Vector3Int playerTileCell = tilemapGrid.WorldToCell(playerPosNoZ);
    //    Debug.Log(playerTileCell); //play pos real time, cell (?) <--- PLAYER POS, REAL TIME

    //    TileBase tileUnderPlayer = rockTilemap.GetTile(playerTileCell);
    //    Debug.Log(tileUnderPlayer);// tells you tile under player (?)
    //}


    //pickaxeCheck = GameObject.Find("isPickaxe").GetComponent<isPickaxe>();




    [SerializeField] Grid tilemapGrid;
    [SerializeField] Tilemap rockTilemap;
    [SerializeField] Rigidbody2D playerRb;
    [SerializeField] GameCursor gC;
    [SerializeField] Vector3 maxOffset = new Vector3(2f, 2f, 2f);

    void Update()
    {
        ClickOnRock(); // if PlayerInOffset == true && isPickaxe == true
    }

    bool PlayerInOffset(Vector3 pos1, Vector3 pos2, Vector3 offset) // use in ClickOnRock(); compares cursor pos world & player pos world; must be near to be able to click
    {
        return System.Math.Abs(pos1.x - pos2.x) <= offset.x && System.Math.Abs(pos1.y - pos2.y) <= offset.y;
    }

    //compare tileUnderCursor and tileUnderPlayer distance (offset); must be near to click as well ^^

    void ClickOnRock()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousePosNoZ = new Vector3(mousePos.x, mousePos.y);// cursor pos real time, 2D world

        Vector3Int mouseTileCell = tilemapGrid.WorldToCell(mousePosNoZ); // cursor pos real time, cell 
        TileBase tileUnderCursor = rockTilemap.GetTile(mouseTileCell); // Rock under cursor ****

        Vector3 playerPos = playerRb.transform.position;
        Vector3 playerPosNoZ = new Vector3(playerPos.x, playerPos.y); //player pos real time, 2D world

        Vector3Int playerTileCell = tilemapGrid.WorldToCell(playerPosNoZ); //player pos real time, cell *
        TileBase tileUnderPlayer = rockTilemap.GetTile(playerTileCell); //tile under player ***


        // need to compare tileUnderCursor and tileUnderPlayer ALSO

        if (PlayerInOffset(mousePosNoZ, playerPosNoZ, maxOffset) && gC.isPickaxe == true) // add tileUnderCursor and tileUnderPlayer conditional
        {
            //onMouseDown to "mine"
            Debug.Log("Kenny Can Mine!");
        }


    }


}
