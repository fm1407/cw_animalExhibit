using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RotatorSliderSoreya : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, slider.value, 0);
    }
}
