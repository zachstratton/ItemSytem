﻿using UnityEngine;
using UnityEditor;
using System.Collections;
using System;

namespace Drottin.ItemSystem
{

    [System.Serializable]
    public class ISWeapon : ISObject, IISWeapon, IISDestructible, IISEquipable, IISGameObject
    {
        [SerializeField]int _minDamage;
        [SerializeField]int _durability;
        [SerializeField]int _maxDurability;
        [SerializeField]
        ISEquipmentSlot _equipmentSlot;
        [SerializeField]
        GameObject _prefab;


        public ISWeapon()
        {
            _equipmentSlot = new ISEquipmentSlot();
        }

        public ISWeapon(int durability, int maxDurability, ISEquipmentSlot equipmentSlot, GameObject prefab)
        {
            _durability = durability;
            _maxDurability = maxDurability;
            _equipmentSlot = equipmentSlot;
            _prefab = prefab;
        }



        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }




        public int Attack()
        {
            throw new NotImplementedException();
        }




        public int Durability
        {
            get { return _durability; }
        }

        public int MaxDurability
        {
            get { return _maxDurability; }
        }

        public void TakeDamage(int amount)
        {
            _durability -= amount;

            if (_durability < 0)
                _durability = 0;

            if (_durability == 0)
                Break();
        }


        //reduce the dura to 0
        public void Break()
        {
            _durability = 0;
        }

        public void Repair()
        {
            _maxDurability--;

            if(_maxDurability > 0)
                _durability = _maxDurability;
        }

        public ISEquipmentSlot EquipmentSlot
        {
            get { return _equipmentSlot; }
        }


        public bool Equip()
        {
            throw new NotImplementedException();
        }


        public GameObject Prefab
        {
            get { return _prefab; }
        }


        //new script later
        public override void OnGUI()
        {
            base.OnGUI();

            _minDamage = System.Convert.ToInt32(EditorGUILayout.TextField("Damage: ", _minDamage.ToString()));
            _durability = System.Convert.ToInt32(EditorGUILayout.TextField("Durability: ", _durability.ToString()));
            _maxDurability = System.Convert.ToInt32(EditorGUILayout.TextField("Durability: ", _maxDurability.ToString()));

            DisplayEquipmentSlot();
            DisplayPrefab();
        }

        public void DisplayEquipmentSlot()
        {
            GUILayout.Label("Quipe");
        }

        public void DisplayPrefab()
        {
            _prefab = EditorGUILayout.ObjectField("Prefab", _prefab, typeof(GameObject), false) as GameObject;
        }
    }
}
