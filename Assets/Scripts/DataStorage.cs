using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataStorage
{
    /*Appearance Data*/
    /* Text Column 1 variable */
    private static string metabolism = "--", bodytype = "--", breasttype = "--", skintone = "--", skincolor = "--";
    /* Text Column 2 variable */
    private static string hairtype = "--", hairline = "--", haircolor = "--", naturalshades = "--", naturaltint = "--";
    /* Text Column 3 variable */
    private static string faceshape = "--", eyeshape = "--", eyecolor = "--", eyecolor2 = "--";

    /*Gender & Sexuality*/
    /* Text Column 1 variable */
    private static string assignedsex = "--", genderidentity = "--", genderexpression = "--", style = "--";
    /* Text Column 2 variable */
    private static string transdenom = "--", nonbinarydenom = "--", nonbinarydenom2 = "--", polygender = "--", polygender2 = "--";
    /* Text Column 3 variable */
    private static string attractedto = "--", attractedto2 = "--", orientationtype = "--", romantic = "--", mismatching1 = "--", mismatching2 = "--";

    /*Facial Features*/
    private static string browplacement = "--", browshape = "--";
    private static string nosebridge = "--", nosetip = "--", nosewing = "--";
    private static string lipshape = "--", lipthickness = "--", cupidsbow = "--";

    /*Other variables*/
    private static bool asexual = false, intersex = false, nonbinary = false, polysexual = false;


    public static string Metabolism
    {
        get
        {
            return metabolism;
        }
        set
        {
            metabolism = value;
        }
    }

    public static string BodyType
    {
        get
        {
            return bodytype;
        }
        set
        {
            bodytype = value;
        }
    }

    public static string BreastType
    {
        get
        {
            return breasttype;
        }
        set
        {
            breasttype = value;
        }
    }

    public static string SkinTone
    {
        get
        {
            return skintone;
        }
        set
        {
            skintone = value;
        }
    }

    public static string SkinColor
    {
        get
        {
            return skincolor;
        }
        set
        {
            skincolor = value;
        }
    }

    public static string HairType
    {
        get
        {
            return hairtype;
        }
        set
        {
            hairtype = value;
        }
    }

    public static string HairLine
    {
        get
        {
            return hairline;
        }
        set
        {
            hairline = value;
        }
    }

    public static string HairColor
    {
        get
        {
            return haircolor;
        }
        set
        {
            haircolor = value;
        }
    }

    public static string NaturalShades
    {
        get
        {
            return naturalshades;
        }
        set
        {
            naturalshades = value;
        }
    }

    public static string NaturalTint
    {
        get
        {
            return naturaltint;
        }
        set
        {
            naturaltint = value;
        }
    }

    public static string FaceShape
    {
        get
        {
            return faceshape;
        }
        set
        {
            faceshape = value;
        }
    }

    public static string EyeShape
    {
        get
        {
            return eyeshape;
        }
        set
        {
            eyeshape = value;
        }
    }
    public static string EyeColor
    {
        get
        {
            return eyecolor;
        }
        set
        {
            eyecolor = value;
        }
    }

    public static string EyeColor2
    {
        get
        {
            return eyecolor2;
        }
        set
        {
            eyecolor2 = value;
        }
    }

    public static string AssignedSex
    {
        get
        {
            return assignedsex;
        }
        set
        {
            assignedsex = value;
        }
    }


    public static string GenderIdentity
    {
        get
        {
            return genderidentity;
        }
        set
        {
            genderidentity = value;
        }
    }

    public static string GenderExpression
    {
        get
        {
            return genderexpression;
        }
        set
        {
            genderexpression = value;
        }
    }


    public static string Style
    {
        get
        {
            return style;
        }
        set
        {
            style = value;
        }
    }


    public static string TransDenom
    {
        get
        {
            return transdenom;
        }
        set
        {
            transdenom = value;
        }
    }

    public static string NonBinaryDenom
    {
        get
        {
            return nonbinarydenom;
        }
        set
        {
            nonbinarydenom = value;
        }
    }

    public static string Polygender
    {
        get
        {
            return polygender;
        }
        set
        {
            polygender = value;
        }
    }

    public static string Polygender2
    {
        get
        {
            return polygender2;
        }
        set
        {
            polygender2 = value;
        }
    }

    public static string NonBinaryDenom2
    {
        get
        {
            return nonbinarydenom2;
        }
        set
        {
            nonbinarydenom2 = value;
        }
    }

    public static string AttractedTo
    {
        get
        {
            return attractedto;
        }
        set
        {
            attractedto = value;
        }
    }

    public static string AttractedTo2
    {
        get
        {
            return attractedto2;
        }
        set
        {
            attractedto2 = value;
        }
    }

    public static string OrientationType
    {
        get
        {
            return orientationtype;
        }
        set
        {
            orientationtype = value;
        }
    }

    public static string RomanticType
    {
        get
        {
            return romantic;
        }
        set
        {
            romantic = value;
        }
    }

    public static string MismatchingType
    {
        get
        {
            return mismatching1;
        }
        set
        {
            mismatching1 = value;
        }
    }

    public static string MismatchingType2
    {
        get
        {
            return mismatching2;
        }
        set
        {
            mismatching2 = value;
        }
    }


    public static string BrowPlacement
    {
        get
        {
            return browplacement;
        }
        set
        {
            browplacement = value;
        }
    }

    public static string BrowShape
    {
        get
        {
            return browshape;
        }
        set
        {
            browshape = value;
        }
    }

    public static string NoseBridge
    {
        get
        {
            return nosebridge;
        }
        set
        {
            nosebridge = value;
        }
    }

    public static string NoseTip
    {
        get
        {
            return nosetip;
        }
        set
        {
            nosetip = value;
        }
    }

    public static string NoseWing
    {
        get
        {
            return nosewing;
        }
        set
        {
            nosewing = value;
        }
    }


    public static string LipShape
    {
        get
        {
            return lipshape;
        }
        set
        {
            lipshape = value;
        }
    }

    public static string LipThickness
    {
        get
        {
            return lipthickness;
        }
        set
        {
            lipthickness = value;
        }
    }

    public static string CupidsBow
    {
        get
        {
            return cupidsbow;
        }
        set
        {
            cupidsbow = value;
        }
    }

    public static bool IsAsexual
    {
        get
        {
            return asexual;
        }
        set
        {
            asexual = value;
        }
    }
    public static bool IsIntersex
    {
        get
        {
            return intersex;
        }
        set
        {
            intersex = value;
        }
    }
    public static bool IsNonBinary
    {
        get
        {
            return nonbinary;
        }
        set
        {
            nonbinary = value;
        }
    }

    public static bool IsPolysexual
    { 
        get
        {
            return polysexual;
        }
        set
        {
            polysexual = value;
        }
    }
}