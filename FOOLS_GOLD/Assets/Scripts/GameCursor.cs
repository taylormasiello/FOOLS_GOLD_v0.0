using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCursor : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Button backpackBtn;
    [SerializeField] Texture2D searchingCursorTexture;
    [SerializeField] Texture2D miningCursorTexture;

    //public int btnClickCounter = 0;
    public bool isPickaxe;

    void Start()
    {
        SetSearchingCursor(searchingCursorTexture);
        isPickaxe = false;
        backpackBtn.onClick.AddListener(TogglePickaxe);
    }


    public void SetSearchingCursor(Texture2D texture)
    {
        Cursor.SetCursor(searchingCursorTexture, Vector2.zero, CursorMode.Auto);
    }

    public void SetMiningCursor(Texture2D texture)
    {
        Cursor.SetCursor(miningCursorTexture, Vector2.zero, CursorMode.Auto);
    }

    public void TogglePickaxe()
    {
        if (!isPickaxe)
        {
            isPickaxe = true;
            SetMiningCursor(miningCursorTexture);
        }
        else if (isPickaxe)
        {
            isPickaxe = false;
            SetSearchingCursor(searchingCursorTexture);
        }


    }

}
