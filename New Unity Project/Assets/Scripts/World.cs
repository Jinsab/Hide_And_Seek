using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    public Material material;
    public BlockType[] blockTypes;

}

[System.Serializable]
public class BlockType
{
    public string blockName;
    public bool isSolid;

    [Header("Textrue Values")]
    public int backFaceTextrue;
    public int frontFaceTextrue;
    public int topFaceTextrue;
    public int bottomFaceTextrue;
    public int leftFaceTextrue;
    public int rightFaceTextrue;
    // Back, Front, Top, Bottom, Left, Right

    public int GetTextrueID (int faceIndex)
    {
        switch (faceIndex)
        {
            case 0:
                return backFaceTextrue;

            case 1:
                return frontFaceTextrue;

            case 2:
                return topFaceTextrue;

            case 3:
                return bottomFaceTextrue;

            case 4:
                return leftFaceTextrue;

            case 5:
                return rightFaceTextrue;

            default:
                Debug.Log("Error in GetTextrueID; invalid face index");
                return 0;
        }
    }
}
