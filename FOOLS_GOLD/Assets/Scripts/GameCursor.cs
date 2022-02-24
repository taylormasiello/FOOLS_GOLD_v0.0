using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCursor : MonoBehaviour
{
<<<<<<< HEAD
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
=======
    [SerializeField] Texture2D searchingCursorTexture;
    [SerializeField] Texture2D miningCursorTexture;

    //Cursor searchingCursor;
    //Cursor miningCursor;

    // Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); 

    void Start()
    {
        SetSearchingCursor(searchingCursorTexture);
    }

    public void SetSearchingCursor(Texture2D texture)
    {
        Cursor.SetCursor(searchingCursorTexture, Vector2.zero, CursorMode.Auto);
    }

    public void SetMiningCursor(Texture2D texture)
    {
        Cursor.SetCursor(miningCursorTexture, Vector2.zero, CursorMode.Auto);
>>>>>>> parent of 034aeac (cleaned up code)
    }
}
