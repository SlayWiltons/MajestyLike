using UnityEngine;

public class BaseSpawner : MonoBehaviour
{
    [System.Serializable]
    public class CharacterOfBuilding
    {
        public Character Character;
        public int Quantity;
    }

    public CharacterOfBuilding[] _characters;
}
