using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
    public TextMeshProUGUI txtNameLeft;
    public Image imgSpriteLeft;

    public TextMeshProUGUI txtNameRight;
    public Image imgSpriteRight;

    public TextMeshProUGUI txtSentence;

    private DialogConfig _dialog;
    private int _idCurrentSentence = 0;

    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayDialog(DialogConfig dialog)
    {
        gameObject.SetActive(true);

        //txtNameLeft.text = dialog.nameLeft;
        //imgSpriteLeft.sprite = dialog.spriteLeft;

        //txtNameRight.text = dialog.nameRight;
        //imgSpriteRight.sprite = dialog.spriteRight;
        
        _dialog = dialog;

        RefreshBox();
    }

    private void RefreshBox()
    {
        DialogConfig.SentenceConfig sentence = _dialog.sentenceConfig[_idCurrentSentence];

        DialogConfig.SpeakerConfig speaker = _dialog.speakers[0];

        switch (speaker.position)
        {
            case DialogConfig.SpeakerConfig.POSITION.LEFT:
                txtNameLeft.color = Color.black;
                txtNameRight.color = Color.clear;
                
                imgSpriteLeft.color = Color.white;
                imgSpriteRight.color = Color.gray;
                break;

            case DialogConfig.SpeakerConfig.POSITION.RIGHT:
                txtNameLeft.color = Color.clear;
                txtNameRight.color = Color.black;

                imgSpriteLeft.color = Color.gray;
                imgSpriteRight.color = Color.white;
                break;
        }

        txtSentence.text = sentence.sentence;

        _audioSource.Stop();
        
        _audioSource.clip = sentence.audioClip;
        _audioSource.Play();
    }

    public void NextSentence()
    {
        _idCurrentSentence++;

        if (_idCurrentSentence < _dialog.sentenceConfig.Count) 
            RefreshBox();
        else
            CloseDialog();
    }

    private void CloseDialog()
    {
        _idCurrentSentence = 0;
        _dialog = null;

        gameObject.SetActive(false);
    }
}
