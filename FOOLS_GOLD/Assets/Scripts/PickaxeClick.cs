using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class PickaxeClick : MonoBehaviour
{

    
    [SerializeField] Tilemap rockTilemap;
    

    //private Grid grid;
    //private Vector3Int previousMousePos = new Vector3Int();

    void Start()
    {
       //grid = gameObject.GetComponent<Grid>();   
    }

    void Update()
    {
        Vector3Int mousePos = GetMousePoisition();

        if (mousePos.))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(gameObject);
            }
        }


    }

    void OnMouseDown()
    {
        
    }

    Vector3Int GetMousePoisition()
    {
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return grid.WorldToCell(mouseWorldPosition);
    }

    // to call function from a different GAMEOBJ.GetComponent<SCRIPTNAME>().FUNTIONFROMSCRIPT();
}
