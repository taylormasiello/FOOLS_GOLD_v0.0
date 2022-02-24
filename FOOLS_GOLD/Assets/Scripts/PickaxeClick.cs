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

    //Vector3Int previousMousePos = new Vector3Int();

    //void Start()
    //{
    //    tilemapGrid = gameObject.GetComponent<Grid>();
    //}

    void Update()
    {
        Vector3Int mousePos = GetMousePos();

        if (Input.GetMouseButtonDown(0))
        {
            rockTilemap.DeleteCells(mousePos, 1, 1, 1);
            Debug.Log("you deleted a rock with a click");
        }
        
    }

    Vector3Int GetMousePos()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return tilemapGrid.WorldToCell(mouseWorldPos);
    }


    // tilemap obj: .DelectCells (instead of Destory.obj ?)
}
