using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayFaceDetails : MonoBehaviour {

    public Text browplacement, browshape;
    public Text nosebridge, nosetip, nosewings;
    public Text lipshape, lipthickness, cupidsbow;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        UpdateText();
    }


    void UpdateText()
    {

        browplacement.text = DataStorage.BrowPlacement;
        browshape.text = DataStorage.BrowShape;

        nosebridge.text = DataStorage.NoseBridge;
        nosetip.text = DataStorage.NoseTip;
        nosewings.text = DataStorage.NoseWing;

        lipshape.text = DataStorage.LipShape;
        lipthickness.text = DataStorage.LipThickness;
        cupidsbow.text = DataStorage.CupidsBow;

    }
}
