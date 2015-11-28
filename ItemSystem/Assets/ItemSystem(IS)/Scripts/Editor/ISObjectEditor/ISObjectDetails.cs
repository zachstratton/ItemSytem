using UnityEngine;
using System.Collections;

namespace Drottin.ItemSystem.Editor
{

    public partial class ISObjectEditor
    {
        ISWeapon tempWeapon = new ISWeapon();
        bool toggleNewWeaponDetails = false;

        void ItemDetails()
        {
            GUILayout.BeginVertical("box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            GUILayout.BeginVertical(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));

            if (toggleNewWeaponDetails)
                DisplayNewWeapon();

            GUILayout.EndVertical();

            GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
            DisplayButton();
            GUILayout.EndHorizontal();
            GUILayout.EndVertical();
        }



        void DisplayNewWeapon()
        {
            GUILayout.BeginVertical(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            tempWeapon.OnGUI();
            GUILayout.EndVertical();
        }



        void DisplayButton()
        {
            if (!toggleNewWeaponDetails)
            {
                if (GUILayout.Button("Create New Weapon"))
                {
                    tempWeapon = new ISWeapon();
                    toggleNewWeaponDetails = true;
                }
            }
            else
            {

                if (GUILayout.Button("Save Weapon"))
                {
                    toggleNewWeaponDetails = false;
                    tempWeapon = null;
                }

                if (GUILayout.Button("Cancel"))
                {
                    toggleNewWeaponDetails = true;
                    tempWeapon = null;
                }

            }
        }

    }
}
