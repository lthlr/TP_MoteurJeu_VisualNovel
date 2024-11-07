using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{
    public TMP_Text TextDialog;
    public TMP_Text TextCharacterName;
    public Image ImageCharacter;
    public DialogSequence[] Dialogs;
    public int _sequenceNumber;


    private void Start()
    {
        UpdateDialogSequence(Dialogs[0]);
    }

    private void UpdateDialogSequence(DialogSequence sequence)
    {
        TextDialog.text = sequence.TextDialog;
        TextCharacterName.text = sequence.TextnameCharacter;
        ImageCharacter.sprite = sequence.SpriteCharacter;
    }

    public void OnClickNextDialog()
    {
        _sequenceNumber++;
        UpdateDialogSequence(Dialogs[_sequenceNumber]);
    }

}


