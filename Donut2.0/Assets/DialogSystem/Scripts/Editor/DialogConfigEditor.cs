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

    private SerializedProperty _characters,_sentences;

    private int _index;
    private void OnEnable()
    {
        _target = (DialogConfig)target;
        _class = new SerializedObject(_target);

        _characters = _class.FindProperty("characters");
        _sentences = _class.FindProperty("sentences");
    }

    public override void OnInspectorGUI() {
    //   this.DrawDefaultInspector();

        EditorGUILayout.PropertyField(_characters);
        //EditorGUILayout.PropertyField(_sentences);
    }
}
