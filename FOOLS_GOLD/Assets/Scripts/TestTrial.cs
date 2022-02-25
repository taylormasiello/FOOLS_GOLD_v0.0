using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.UIElements;
using UnityEngine.Tilemaps;

public class TestTrial : MonoBehaviour
{





    // .OnMouseDown <-- "event listener"

    [SerializeField] Grid tilemapGrid;
    [SerializeField] Tilemap rockTilemap;
    [SerializeField] Rigidbody2D playerRb;

    void Update()
    {
        ClickOnRock();
    }

    void ClickOnRock() 
    {
        var playerPos = playerRb.transform.position;
        var playerPosNoZ = new Vector3(playerPos.x, playerPos.y);
        Vector3Int playerTileCell = tilemapGrid.WorldToCell(playerPosNoZ);
        Debug.Log(playerTileCell); //play pos real time (?)

        var tileUnderPlayer = rockTilemap.GetTile(playerTileCell);
        Debug.Log(tileUnderPlayer);// tells you tile under player (?)

        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var mousePosNoZ = new Vector3(mousePos.x, mousePos.y);
        Vector3Int mouseTileCell = tilemapGrid.WorldToCell(mousePosNoZ);
        Debug.Log(mouseTileCell); // cursor pos real time

        var tileUnderCursor = rockTilemap.GetTile(mouseTileCell); 
        Debug.Log(tileUnderCursor); // tells you tile under cursor

        // attempt to make a tile behave like a clickable (button) obj
        //if (Input.GetMouseButtonUp(0))
        //{
        //    var tileUnderMouse = rockTilemap.GetTile(mouseTileCell); // tracking cursor cell pos real-time

        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        Debug.Log("tile click", tileUnderMouse);
        //    }
        //}
    }

}



