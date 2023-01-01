using UnityEngine;

[CreateAssetMenu(fileName = "New resource", menuName = "Resource")]
public class Resource : ScriptableObject
{
    public string Name;
    public int Count;
}
