using UnityEngine;

namespace DictionarySerialization.Example
{
    [CreateAssetMenu(
        fileName = "ResourceDictionary",
        menuName = "ScriptableObjects/ResourceDictionary",
        order = 1)]
    public class ResourceDictionarySO : ScriptableObject
    {
        [SerializeField]
        private ResourceDictionary _resources;
    }
}