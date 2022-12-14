using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    bool isSelected;
    public SpriteRenderer sr;
    public string id;
    [SerializeField]private bool availability;

    private void Start()
    {
        isSelected = false;
        availability = true;
    }

    public void ToggleSelected(bool b) {
        isSelected = b;
    }

    public void ToggleColor(Color clr) {
        sr.color = clr;
    }

    public bool CheckForLocationAvailability() {
        return availability;
    }

    public void SetAvailable(bool b) {
        availability = b;   
    }

}
