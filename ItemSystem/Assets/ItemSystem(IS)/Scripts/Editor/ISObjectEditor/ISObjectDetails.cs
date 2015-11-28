using UnityEngine;
using System.Collections;

namespace Drottin.ItemSystem.Editor
{

    public partial class ISObjectEditor
    {
        void ItemDetails()
        {
            GUILayout.BeginHorizontal("box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));

            GUILayout.Label("Status Bar Views");

            GUILayout.EndHorizontal();
        }
    }
}
