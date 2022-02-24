using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCursor : MonoBehaviour
{
    [SerializeField] Texture2D searchingCursorTexture;
    [SerializeField] Texture2D miningCursorTexture;

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
    }
}
