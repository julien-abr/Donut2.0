using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = System.Object;


[CustomEditor(typeof(DialogConfig))]
public class DialogConfigEditor : Editor {

    private DialogConfig _target;
    private SerializedObject _class;

    private SerializedProperty _characters,_charactersSprite,_sentences;

    private int _index;
    private void OnEnable()
    {
        _target = (DialogConfig)target;
        _class = new SerializedObject(_target);

        _characters = _class.FindProperty("characters");
        _charactersSprite = _class.FindProperty("charactersSprite");
        _sentences = _class.FindProperty("sentences");
    }

    public override void OnInspectorGUI() {
       DrawDefaultInspector();

       
        /*EditorGUILayout.PropertyField(_characters);
        EditorGUILayout.PropertyField(_charactersSprite);
        
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Sentences");

        for (int i = 0; i < _target.sentences.Count; i++) {
            DialogConfig.Sentence sentence = _target.sentences[i];
            sentence.talker = "Moi";

            _target.sentences[i] = sentence;
        }
        
        foreach(DialogConfig.Sentence sentence in _target.sentences) 
            Debug.Log("talker " + sentence.talker);
        */
        //EditorGUILayout.PropertyField(_sentences);

        // RESET LES VALEURS AVEC REASGIGNANT UNE NOUVELLE CLASSE

        // DialogConfig config = _srouce.config[i]
        //
        // config.speaker = EditGuiLayout.Popup();
        // source.config[i] = config

    }
}
