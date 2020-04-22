using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputNameAudio : MonoBehaviour
{
    public AudioSource audioKeyBoard;
    public UnityEngine.UI.InputField inputText;

    private void Start() {
        this.audioKeyBoard = GetComponent<AudioSource>();
    }

    public void TextChanged(string text) {
        bool resultado = text.Equals("");

        if (resultado) audioKeyBoard.Play(0);
    }

}
