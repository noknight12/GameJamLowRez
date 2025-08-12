using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AbstractDunegeonGen), true)]
public class RandomDungeonEditor : Editor
{
    AbstractDunegeonGen generator;

    private void Awake() 
    {
        generator = (AbstractDunegeonGen)target;
    }
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if(GUILayout.Button("Create Dungeon"))
        {
            generator.GenerateDungeon();
        }
        if (GUILayout.Button("Clear Dungeon"))
        {
            generator.ClearDungeon();
        }
    }
}
