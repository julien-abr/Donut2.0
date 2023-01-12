using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DialogController))]
public class DialogControllerEditor : Editor {
    
    private DialogController _target;
    private SerializedObject _class;


    private int _index;
    private void OnEnable() {
        _target = (DialogController)target;
        _class = new SerializedObject(_target);
    }
    
    public override void OnInspectorGUI() {
        DrawDefaultInspector();
        if (GUILayout.Button("Generate Sentences")) {
           
        }
    }
}
