using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiningCursor : MonoBehaviour
{
    [SerializeField] GameObject gameCursor;
    [SerializeField] Button backpackBtn;

    [SerializeField] Texture2D miningCursor;
    [SerializeField] Texture2D searchingCursor;

    //UnityEvent equipPickaxe;

    void Start()
    {
        backpackBtn.onClick.AddListener(EquipPickaxe);

        //equipPickaxe.AddListener(EquipPickaxe);
    }

    void EquipPickaxe()
    {
        gameCursor.GetComponent<GameCursor>().SetMiningCursor(miningCursor);
    }

    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0) && equipPickaxe != null)
    //    {
    //        equipPickaxe.Invoke();
    //    }

    //}
}
