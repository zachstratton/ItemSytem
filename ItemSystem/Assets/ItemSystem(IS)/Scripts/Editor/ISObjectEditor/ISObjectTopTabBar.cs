using UnityEngine;
using System.Collections;

namespace Drottin.ItemSystem.Editor
{

    public partial class ISObjectEditor
    {
        void TopTabBar()
        {
            GUILayout.BeginHorizontal("box", GUILayout.ExpandWidth(true));
            WeaponTab();
            ArmourTab();
            GUILayout.Button("Potions");
            AboutTab();
            GUILayout.EndHorizontal();
        }



        void WeaponTab()
        {
            GUILayout.Button("Weapons");
        }



        void ArmourTab()
        {
            GUILayout.Button("Armour");
        }



        void AboutTab()
        {
            GUILayout.Button("About");
        }
    }
}