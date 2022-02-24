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
    [SerializeField] Grid tilemapGrid;
    [SerializeField] Tilemap rockTilemap; 

    [SerializeField] GameObject player;
    [SerializeField] CapsuleCollider2D playerCollider;

    Collision2D playerToMine;
    ContactPoint2D[] playToRockContacts = new ContactPoint2D[2];

    

    //Vector3 playerWorldPos;

    //void GetPlayWorldPos()
    //{
    //    Vector3 playerWorldPos = player.GetComponent<PlayerMovement>().playerWorldPos;
    //}

    void OnCollisionEnter2D(Collision2D playerToMine)
    {
        //makes grid from rocktilemap
        Grid rockTileGrid = rockTilemap.layoutGrid;
        
        //gets array of contact points from collision, makes List from array
        playerToMine.GetContacts(playToRockContacts);
        List<ContactPoint2D> contactPointsList = new List<ContactPoint2D>(playToRockContacts);

        //stores both contactPoints from array into variables
        ContactPoint2D collsionPt1 = contactPointsList[0];
        ContactPoint2D collisionPt2 = contactPointsList[1];

        //get cell coordiantes in which collision points are; converts world position to cell position
        Vector3Int collisionCellPos1 = rockTileGrid.WorldToCell(collsionPt1.point);
        Vector3Int collisionCellPos2 = rockTileGrid.WorldToCell(collisionPt2.point);

        //gets TileBase from collision tile
        TileBase collisionTile1 = rockTilemap.GetTile(collisionCellPos1);
        TileBase collisionTile2 = rockTilemap.GetTile(collisionCellPos2);

        if (!playerCollider.IsTouchingLayers(LayerMask.GetMask("Mining")))
        {
            return;
        }
        else if (contactPointsList != null)
        {
            Debug.Log("Kenny is mining");
        }



        //foreach (var contact in playToRockContacts)
        //{
        //    Debug.Log(contact.point); // each elm in arr is a point: (int x, int y)
        //    // rockTileGrid.WorldToCell(contact.point); // cell coordinates in which collision point is
        //    TileBase collisionTile = rockTilemap.GetTile(rockTileGrid.WorldToCell(contact.point));

        //}

        //tilemapGrid.WorldToCell(playToRockContacts);
        //rockTilemap.GetInstantiatedObject();
    }

    private void OnCollisionExit2D(Collision2D playerToMine)
    {
        Grid rockTileGrid = rockTilemap.layoutGrid;
        playerToMine.GetContacts(playToRockContacts);
        List<ContactPoint2D> contactPointsList = new List<ContactPoint2D>(playToRockContacts);

        ContactPoint2D collsionPt1 = contactPointsList[0];
        ContactPoint2D collisionPt2 = contactPointsList[1];

        Vector3Int collisionCellPos1 = rockTileGrid.WorldToCell(collsionPt1.point);
        Vector3Int collisionCellPos2 = rockTileGrid.WorldToCell(collisionPt2.point);

        TileBase collisionTile1 = rockTilemap.GetTile(collisionCellPos1);
        TileBase collisionTile2 = rockTilemap.GetTile(collisionCellPos2);

        if (playerCollider.IsTouchingLayers(LayerMask.GetMask("Mining")))
        {
            return;
        }
        else if (contactPointsList != null)
        {
            Debug.Log("Kenny is finished mining");
        }
    }

    void Pickaxe()
    {
        //Captures WORLD space for player and cursor
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 playerPos = player.GetComponent<PlayerMovement>().playerWorldPos;

        //Converts world space click point to tile map click point
        Vector3Int mousePosTranslated = rockTilemap.WorldToCell(mousePos);

        //Converts player world space to tile map space
        Vector3Int playerPosTranslated = rockTilemap.WorldToCell(playerPos);

        //Gives clicked on by cursor tile
        TileBase clickedTile = rockTilemap.GetTile<TileBase>(mousePosTranslated);

        //Gives touched by Kenny tile
        TileBase touchedtile = rockTilemap.GetTile<TileBase>(playerPosTranslated);

        //(mousePosTranslated == playerPosTranslated) \\ (clickedTile == touchedtile)




    }
}
