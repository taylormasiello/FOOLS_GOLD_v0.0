using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;

public class MouseCursor : MonoBehaviour
{
    [SerializeField] Texture2D defaultCursor; // torch for now
    [SerializeField] Texture2D miningCursor;

    // Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //  

    private void Start()
    {
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
    }
}
