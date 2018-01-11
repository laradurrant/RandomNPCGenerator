using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAppearance : MonoBehaviour
{

    public Text metabolism, bodytype, breasttype, skintone, skincolor;
    public Text hairtype, hairline, haircolor, naturalshades, naturaltint;
    public Text faceshape, eyeshape, eyecolor, eyecolor2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateText();
    }


    void UpdateText()
    {

        metabolism.text = DataStorage.Metabolism;
        bodytype.text = DataStorage.BodyType;
        breasttype.text = DataStorage.BreastType;
        skintone.text = DataStorage.SkinTone;
        skincolor.text = DataStorage.SkinColor;

        hairtype.text = DataStorage.HairType;
        hairline.text = DataStorage.HairLine;
        haircolor.text = DataStorage.HairColor;
        naturalshades.text = DataStorage.NaturalShades;
        naturaltint.text = DataStorage.NaturalTint;

        faceshape.text = DataStorage.FaceShape;
        eyeshape.text = DataStorage.EyeShape;
        eyecolor.text = DataStorage.EyeColor;
        eyecolor2.text = DataStorage.EyeColor2;

    }
}