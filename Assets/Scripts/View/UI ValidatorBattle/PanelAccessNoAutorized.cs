using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelAccessNoAutorized : MonoBehaviour
{
    public GameObject panelValidacionAcceso;
    public GameObject objetoPlayer;
    private AccessBattlePanal accesoBattleValidation;
    
    void Start()
    {
        this.accesoBattleValidation = this.objetoPlayer.GetComponent<AccessBattlePanal>();
        this.panelValidacionAcceso.SetActive(false);
    }

    void Update()
    {
        if (this.accesoBattleValidation.RetornarValorActivacionPanel())        
            this.panelValidacionAcceso.SetActive(true);

        if (!this.accesoBattleValidation.RetornarValorActivacionPanel())
            this.panelValidacionAcceso.SetActive(false);
            
    }


}
