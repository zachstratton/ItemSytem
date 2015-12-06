﻿using UnityEngine;
using UnityEditor;
using System.Collections;

namespace Drottin.ItemSystem.Editor
{

    public partial class ISObjectEditor
    {
        Vector2 _scrollPos = Vector2.zero;
        int _listViewWidth = 200;
        int _listViewButtonWidth = 150;
        int _listViewButtonHeight = 25;

        void ListView()
        {
            _scrollPos = GUILayout.BeginScrollView(_scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(_listViewWidth));

            GUILayout.Label("List Views");

            for(int cnt = 0; cnt < database.Count; cnt++)
            {
                GUILayout.Button(database.Get(cnt).Name, "box", GUILayout.Width(_listViewButtonWidth), GUILayout.Height( _listViewButtonHeight));

            }

            GUILayout.EndScrollView();
        }
    }
}
