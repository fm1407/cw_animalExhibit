using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera IntroCam;
    public Camera TpsCam;
    bool introCam = true;
    void Start()
    {
        IntroCam.enabled = introCam;
        TpsCam.enabled = !introCam;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            introCam = !introCam;
            IntroCam.enabled = introCam;
            TpsCam.enabled = !introCam;
        }
    }
}
