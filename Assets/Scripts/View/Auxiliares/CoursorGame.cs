using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoursorGame : MonoBehaviour
{
    public Texture2D textureImage;

    void Start()
    {
        Debug.Log(Application.dataPath);

        Vector2 vec = new Vector2(this.textureImage.width * 0.5f, this.textureImage.height * 0.5f);
        Cursor.SetCursor(this.textureImage, vec, CursorMode.ForceSoftware);
    }
}
