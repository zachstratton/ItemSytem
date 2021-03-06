﻿using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Drottin.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor : EditorWindow
    {
        ISQualityDatabase qualityDatabase;
        Texture2D selectedTexture;
        int selectedIndex = -1;
        Vector2 _scrollPos;                             //scroll position in ListView

        const int SPRITE_BUTTON_SIZE = 46;

        const string DATABASE_NAME = @"ISQualityDatabase.asset";
        const string DATABASE_PATH = @"Database";
        const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;



        [MenuItem("GameItems/Database/Quality Editor %#o")]
        public static void Init()
        {
            ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
            window.minSize = new Vector2(400, 300);
            window.titleContent.text = "Quality Database";
            window.Show();
        }

        void OnEnable()
        {
            if( qualityDatabase == null)
            qualityDatabase = ISQualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH, DATABASE_NAME);
        }

        void OnGUI()
        {
            ListView();

            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            BottomBar();
            GUILayout.EndHorizontal();
        }

        void BottomBar()
        {
            GUILayout.Label("Qualities: " + qualityDatabase.Count);

            if (GUILayout.Button("Add"))
            {
                qualityDatabase.Add(new ISQuality());
            }
        }
    }
}

