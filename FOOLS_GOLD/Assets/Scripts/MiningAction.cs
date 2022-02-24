using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.UIElements;
using UnityEngine.Tilemaps;

public class MiningAction : MonoBehaviour
{
    [SerializeField] Grid tilemapGrid;
    [SerializeField] Tilemap rockTilemap;

    [SerializeField] GameObject player;
    [SerializeField] CapsuleCollider2D playerCollider;

    [SerializeField] Texture2D miningCursor;
    [SerializeField] Texture2D searchingCursor;

    [SerializeField] GameObject gameCursor;
    [SerializeField] UnityEngine.UI.Button backpackBtn;

    //Collision2D playerToMine;
    ContactPoint2D[] playToRockContacts = new ContactPoint2D[2];

    void Start()
    {
        backpackBtn.onClick.AddListener(EquipPickaxe);
        //AddListener(if kenny is touching rock and clicks on rock he is touching --> do things)

    }

    void EquipPickaxe()
    {
        gameCursor.GetComponent<GameCursor>().SetMiningCursor(miningCursor);
    }

    bool CanMineThisRock(Vector3 pos1, Vector3 pos2, Vector3 comp)
    {
        return System.Math.Abs(pos1.x - pos2.x) <= comp.x && System.Math.Abs(pos1.y - pos2.y) <= comp.y;
    }

    //start mining_Action
    void OnCollisionEnter2D(Collision2D playerToMine)
    {
        //makes grid from rocktilemap
        Grid rockTileGrid = rockTilemap.layoutGrid;

        //gets array of contact points from collision, makes List from array
        playerToMine.GetContacts(playToRockContacts);
        List<ContactPoint2D> contactPointsList = new List<ContactPoint2D>(playToRockContacts);

        //stores both contactPoints from array into variables
        ContactPoint2D collsionPt1 = contactPointsList[0];    // I think the first one is the rock
        ContactPoint2D collisionPt2 = contactPointsList[1];   // i think this one is kenny

        //get cell coordiantes in which collision points are; converts world position to cell position
        Vector3Int collisionCellPos1 = rockTileGrid.WorldToCell(collsionPt1.point);
        Vector3Int collisionCellPos2 = rockTileGrid.WorldToCell(collisionPt2.point);

        Vector3 collisionVec3Pos1 = rockTileGrid.WorldToCell(collsionPt1.point);
        Vector3 collisionVec3Pos2 = rockTileGrid.WorldToCell(collisionPt2.point);
        Vector3 maxOffset = new Vector3(2f, 2f, 2f);

        //gets TileBase from collision tile
        TileBase collisionTile1 = rockTilemap.GetTile(collisionCellPos1);   //rock tile kenny collide w/?
        TileBase collisionTile2 = rockTilemap.GetTile(collisionCellPos2);

        if (!playerCollider.IsTouchingLayers(LayerMask.GetMask("Mining")))
        {
            return;
        }
        else if (contactPointsList != null)
        {
            //Debug.Log("Kenny is mining");
            foreach (var contact in playToRockContacts)
            {
                Debug.Log(contact.point);
            }
        }

        if(CanMineThisRock(collisionVec3Pos1, collisionVec3Pos2, maxOffset))
        {
            Debug.Log("kenny can mine this rock");
            if (playerToMine.collider.tag == "Rock" && contactPointsList != null)
            {
                UnityEngine.Cursor.SetCursor(miningCursor, Vector2.zero, CursorMode.Auto);
                
            }
        }

        

            //do
            //{
            //    Debug.Log(Input.GetMouseButtonDown(0));
            //} while (playerToMine.collider.tag == "Rock" && contactPointsList != null);
    }

    //end mining_Action
    void OnCollisionExit2D(Collision2D playerToMine)
    {
        Grid rockTileGrid = rockTilemap.layoutGrid;
        playerToMine.GetContacts(playToRockContacts);
        List<ContactPoint2D> contactPointsList = new List<ContactPoint2D>(playToRockContacts);

        ContactPoint2D collsionPt1 = contactPointsList[0];
        ContactPoint2D collisionPt2 = contactPointsList[1];

        Vector3 collisionVec3Pos1 = rockTileGrid.WorldToCell(collsionPt1.point);
        Vector3 collisionVec3Pos2 = rockTileGrid.WorldToCell(collisionPt2.point);
        Vector3 maxOffset = new Vector3(2f, 2f, 2f);

        Vector3Int collisionCellPos1 = rockTileGrid.WorldToCell(collsionPt1.point);
        Vector3Int collisionCellPos2 = rockTileGrid.WorldToCell(collisionPt2.point);

        TileBase collisionTile1 = rockTilemap.GetTile(collisionCellPos1);
        TileBase collisionTile2 = rockTilemap.GetTile(collisionCellPos2);

        // collision.collider: find the collider of the gameobj your gameobj hits
        if (playerToMine.collider.tag != "Rock")
        {
            return;
        }
        else if (contactPointsList != null)
        {
            //Debug.Log("Kenny is finished mining");
        }

        // switches cursor back from mining (pickaxe) to searching (torch)
        if (CanMineThisRock(collisionVec3Pos1, collisionVec3Pos2, maxOffset))
        {
            if (playerToMine.collider.tag != "Rock" || contactPointsList != null)
            {
                Debug.Log("kenny can no loger mine this rock");
                UnityEngine.Cursor.SetCursor(searchingCursor, Vector2.zero, CursorMode.Auto);
            }                
        }
    }






}
