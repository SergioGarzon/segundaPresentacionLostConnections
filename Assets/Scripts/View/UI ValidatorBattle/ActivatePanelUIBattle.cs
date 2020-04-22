using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePanelUIBattle : MonoBehaviour
{
    public GameObject objetoPlayer;
    public AccessBattlePanal accesoPanel;
    public GameObject panelActivar;
    public Camera cameraOpenWorld;
    public Camera cameraBattlaScene;

    void Start()
    {
        this.accesoPanel = this.objetoPlayer.GetComponent<AccessBattlePanal>();
    }

    void Update()
    {
        if(this.accesoPanel.RetornarActivacionPanelUIBattle())
        {
            this.cameraOpenWorld.gameObject.SetActive(false);
            this.cameraBattlaScene.gameObject.SetActive(true);
            this.panelActivar.gameObject.SetActive(true);
        }
    }






}
