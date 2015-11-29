using UnityEngine;
using UnityEditor;
using System.Collections;


namespace Drottin.ItemSystem.Editor
{
    public partial class ISObjectEditor : EditorWindow
    {
        ISWeaponDatabase database;
      
        const string DATABASE_NAME = @"WeaponDatabase.asset";
        const string DATABASE_PATH = @"Database";
        const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;



        [MenuItem("GameItems/Database/Item System Editor %#i")]
        public static void Init()
        {
            ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
            window.minSize = new Vector2(800, 600);
            window.titleContent.text = "Item System";
            window.Show();
        }



        void OnEnable()
        {
            if (database == null)
                database = ISWeaponDatabase.GetDatabase<ISWeaponDatabase>(DATABASE_PATH, DATABASE_NAME);
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
