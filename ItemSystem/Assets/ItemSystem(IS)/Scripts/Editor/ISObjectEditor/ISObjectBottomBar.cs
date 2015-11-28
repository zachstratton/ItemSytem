using UnityEngine;
using System.Collections;

namespace Drottin.ItemSystem.Editor
{

    public partial class ISObjectEditor
    {
        void BottomBar()
        {
            GUILayout.BeginHorizontal("box", GUILayout.ExpandWidth(true));

            GUILayout.Label("Detail Views");

            GUILayout.EndHorizontal();
        }
    }
}