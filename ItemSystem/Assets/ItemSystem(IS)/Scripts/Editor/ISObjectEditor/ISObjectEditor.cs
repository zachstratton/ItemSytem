using UnityEngine;
using UnityEditor;
using System.Collections;


namespace Drottin.ItemSystem.Editor
{
    public partial class ISObjectEditor : EditorWindow
    {

        [MenuItem("GameItems/Database/Item System Editor %#i")]
        public static void Init()
        {
            ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
            window.minSize = new Vector2(800, 600);
            window.title = "Item System";
            window.Show();
        }



        void OnEnable()
        {

        }



        void OnGUI()
        {
            TopTabBar();

            GUILayout.BeginHorizontal();
            ListView();
            ItemDetails();
            GUILayout.EndHorizontal();

            BottomBar();
        }
    }
}
