using UnityEngine;
using TMPro;

public class SimpleFaceEmotion : MonoBehaviour
{
    public Renderer faceRenderer; // Sphere's MeshRenderer
    public Material smileMat, frownMat, angryMat;
    public TMP_Text faceText,mouthText;

    void Start()
    {
        SetNeutral();
    }

    public void SetSmile()
    {
        faceRenderer.material = smileMat;
        faceText.text = "^  ^";
        mouthText.text = " (  ";
    }

    public void SetFrown()
    {
        faceRenderer.material = frownMat;
        faceText.text = "o  o";
        mouthText.text = " )  ";
    }

    public void SetAngry()
    {
        faceRenderer.material = angryMat;
        faceText.text = " ` ᴖ ´ ";
        mouthText.text = "";
    }

    public void SetNeutral()
    {
        faceRenderer.material.color = Color.white;
        faceText.text = "o o";
        mouthText.text = " |  ";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SetSmile();
        if (Input.GetKeyDown(KeyCode.Alpha2)) SetFrown();
        if (Input.GetKeyDown(KeyCode.Alpha3)) SetAngry();
        if (Input.GetKeyDown(KeyCode.Alpha0)) SetNeutral();
    }
}

