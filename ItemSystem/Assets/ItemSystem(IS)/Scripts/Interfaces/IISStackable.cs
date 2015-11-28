using UnityEngine;
using System.Collections;


namespace Drottin.ItemSystem
{
    public interface IISStackable
    {
        int MaxStack { get; }
        int StackSize(int amount);              //default value of 0

    }
}
