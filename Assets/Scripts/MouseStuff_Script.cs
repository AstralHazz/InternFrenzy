using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseStuff_Script : MonoBehaviour
{

    public Texture2D cursorArrow;
    public Texture2D cursorHover;

    void Start()
    {
        // Cursor.visible = false;
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }
    void OnMouseOver()
    {
        Cursor.SetCursor(cursorHover, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

}
