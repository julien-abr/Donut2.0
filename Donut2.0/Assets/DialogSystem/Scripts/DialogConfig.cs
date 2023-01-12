using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DialogConfig : MonoBehaviour {

    [System.Serializable]
    public struct Sentence {
        public string talker;
        public string sentence;
        public AudioClip audioClip;
        public Sprite talkerSprite;
    }

    
    
    [Header("Characters")] 
    public string[] characters;
    public Sprite[] charactersSprite;

    [Header("Sentences")]
    public List<Sentence> sentences = new List<Sentence>();
}
