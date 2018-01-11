using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayGenderSexuality : MonoBehaviour {

    public Text assignedsex, genderidentity, genderexpression, style;
    public Text transdenom, nonbinarydenom, nonbinarydenom2;
    public Text attractedto, orientationtype, romantictype;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        assignedsex.text = DataStorage.AssignedSex;
        genderidentity.text = DataStorage.GenderIdentity;
        genderexpression.text = DataStorage.GenderExpression;
        style.text = DataStorage.Style;
       

        transdenom.text = DataStorage.TransDenom;
        nonbinarydenom.text = DataStorage.NonBinaryDenom;
        nonbinarydenom2.text = DataStorage.NonBinaryDenom2;

        
		attractedto.text = DataStorage.AttractedTo;
        orientationtype.text = DataStorage.OrientationType;
        romantictype.text = DataStorage.RomanticType;

        
    }
}
