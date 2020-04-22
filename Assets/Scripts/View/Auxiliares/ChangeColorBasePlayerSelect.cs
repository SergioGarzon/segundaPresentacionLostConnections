using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class ChangeColorBasePlayerSelect : MonoBehaviour
{
    void Awake()
    {
        this.GenerarColor();
    }

    private void ColorPorDefecto()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }

    public void GenerarColor()
    {
        GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
    }






   




}

/*
//custom Editor es para colocar 
[CustomEditor(typeof(ChangeColorBasePlayerSelect))]
public class EditorColor: Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ChangeColorBasePlayerSelect change = (ChangeColorBasePlayerSelect) target;

        GUILayout.BeginHorizontal();

        if(GUILayout.Button("Generar Color"))
        {
            change.GenerarColor();
            Debug.Log("Generar Color");
        }

        if(GUILayout.Button("Reset Color"))
        {
            change.Reset();
        }

        GUILayout.EndHorizontal();
    }

}
*/