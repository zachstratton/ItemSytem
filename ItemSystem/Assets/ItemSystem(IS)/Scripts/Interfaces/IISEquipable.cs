using UnityEngine;
using System.Collections;

namespace Drottin.ItemSystem
{
    public interface IISEquipable
    {
        ISEquipmentSlot EquipmentSlot { get; }
        bool Equip();
	}
}
