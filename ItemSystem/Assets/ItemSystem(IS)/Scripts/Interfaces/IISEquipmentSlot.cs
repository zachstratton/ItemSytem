using UnityEngine;
using System.Collections;

namespace Drottin.ItemSystem
{
    public interface IISEquipmentSlot
    {
	    string Name { get; set; }
        Sprite Icon { get; set; }
	}
}
