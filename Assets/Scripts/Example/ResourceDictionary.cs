using System;
using UnityEngine;
using DictionarySerialization.Source;

namespace DictionarySerialization.Example
{
    [Serializable]
    public class ResourceDictionary
        : SerializableDictionary<int, GameObject>
    {
    }
}