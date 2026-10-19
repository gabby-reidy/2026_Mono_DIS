using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// Data (read only): holds info for all player types (none, human, ai)
/// </summary>

public enum ePlayerType {  none, human, AI, terminator };

[CreateAssetMenu(fileName = "New Player Type", menuName = "Scriptable Objects/Create Player Type")]
public class soPlayerTypes : ScriptableObject
{
    public ePlayerType playerType;
    public string playerTypeName;
    public Sprite playerTypeArt;
}
