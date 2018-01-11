using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Debug.Log(System.Reflection.MethodBase.GetCurrentMethod().Name); /* Use this to debug a method */

public class StatGenerator : MonoBehaviour {


    // Use this for initialization
    void Start() {

        UpdateText();
        

    }

    // Update is called once per frame
    void Update() {


        UpdateText();

   
     if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        

    }

    public void RerollStats()
    {
        /* Reroll Appearance */
        /* Column 1*/
        SetMetabolism();
        SetBodyType();
        SetBreastType();
        SetSkinTone();
        SetSkinColor();

        /*Column 2 */
        SetHairType();
        SetHairline();
        SetHairColor();
        SetNaturalShades();
        SetNaturalTint();

        /* Column 3 */
        SetFaceShape();
        SetEyeShape();
        SetEyeColors();
        SetEyeColors2();

        /* Reroll Gender & Sexuality */
        /* Column 1*/
        SetAssignedSex();
        SetGenderIdentity();
        SetGenderExpression();
        SetFashion();
        
        /* Column 2*/
        //TransDenomination();
        //NonBinaryDenomination();
        //NonBinaryDenomination2();

        /* Column 3*/
        //SetSexualOrientation();
        SetOrientationType();
        SetRomanticType();

        /* Face Details */
        SetBrowPlacement();
        SetBrowShape();

        SetNoseBridge();
        SetNoseTipDirection();
        SetNoseWings();

        SetLipShape();
        SetLipThickness();
        SetCupidsBow();
    }

    
    #region NPC Attribute Roll Functions, void returns

 
    /* These functions take nothing and return nothing. Instead, they send the data to DataStorage, a static script for data storage. 
     * This allows persistence between different scenes in Unity.
     */


    void SetMetabolism()
    {
        /* Rolls a random integer in the range 0 to 100 */
        int x = Random.Range(0,101);
     
    
        if (x >= 0 && x <= 20)
        {
            DataStorage.Metabolism = "Endomorph";
        }
        else if (x >= 21 && x <= 40)
        {
            DataStorage.Metabolism = "Ectomorph";
        }
        else if (x >= 41 && x <= 60)
        {
            DataStorage.Metabolism = "Mesomorph";
        }
        else if (x >= 61 && x <= 100)
        {
            DataStorage.Metabolism = "Combination";
        }
        else
        {
            DataStorage.Metabolism = "--";
           
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */
        }
        
    }


    void SetBodyType()
    {

        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 20)
        {
            DataStorage.BodyType = "Triangle";
        }
        else if (x >= 21 && x <= 40)
        {
            DataStorage.BodyType = "Rectangle";

        }
        else if (x >= 41 && x <= 60)
        {
            DataStorage.BodyType = "Hourglass";

        }
        else if (x >= 61 && x <= 80)
        {
            DataStorage.BodyType = "Apple";

        }
        else if (x >= 81 && x <= 100)
        {
            DataStorage.BodyType = "Pear";

        }
        else
        {
            DataStorage.BodyType = "--";

            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */


        }
    }

        void SetBreastType()
        {

            int x = Random.Range(0, 101);

            if (x >= 0 && x <= 5)
            {
                DataStorage.BreastType = "None";
            }
            else if (x >= 6 && x <= 30)
            {
                DataStorage.BreastType = "Flat";
            }
            else if (x >= 31 && x <= 60)
            {
                DataStorage.BreastType = "Swooping";
            }
            else if (x >= 61 && x <= 90)
            {
                DataStorage.BreastType = "Hanging";
            }
            else if (x >= 91 && x <= 100)
            {
                DataStorage.BreastType = "Tube";
            }
            else
            {
                DataStorage.BreastType = "--";

                Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
                /* Outputs an error log with the function's name and variable x. */
            }
        }



    void SetSkinTone()
    {

        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 33)
        {
            DataStorage.SkinTone = "Cool";
        }
        else if (x >= 34 && x <= 66)
        {
            DataStorage.SkinTone = "Neutral";
        }
        else if (x >= 67 && x <= 100)
        {
            DataStorage.SkinTone = "Warm";
        }
        else
        {
            DataStorage.SkinTone = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }
    }



    void SetSkinColor()
    {

        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 20)
        {
            DataStorage.SkinColor = "Very Light";
        }
        else if (x >= 21 && x <= 40)
        {
            DataStorage.SkinColor = "Light";
        }
        else if (x >= 41 && x <= 60)
        {
            DataStorage.SkinColor = "Medium";
        }
        else if (x >= 61 && x <= 80)
        {
            DataStorage.SkinColor = "Dark";
        }
        else if (x >= 81 && x <= 100)
        {
            DataStorage.SkinColor = "Very Dark";
        }
        else
        {
            DataStorage.SkinColor = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }
    }


    void SetHairType()
    {
        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 13)
        {
            DataStorage.HairType = "Straight";

        }
        else if (x >= 14 && x <= 26)
        {
            DataStorage.HairType = "Low Wave";
        }
        else if (x >= 27 && x <= 39)
        {
            DataStorage.HairType = "High Wave";
        }
        else if (x >= 40 && x <= 52)
        {
            DataStorage.HairType = "Loose Curls";
        }
        else if (x >= 53 && x <= 64)
        {
            DataStorage.HairType = "Tight Curls";
        }
        else if (x >= 65 && x <= 76)
        {
            DataStorage.HairType = "S-type Frizz";
        }
        else if (x >= 77 && x <= 88)
        {
            DataStorage.HairType = "Z-type Frizz";
        }
        else if (x >= 89 && x <= 100)
        {
            DataStorage.HairType = "Peppercorn";
        }
        else
        {
            DataStorage.HairType = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }
    }

    void SetHairline()
    {
        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 17)
        {
            DataStorage.HairLine = "Straight";
        }
        else if (x >= 18 && x <= 34)
        {
            DataStorage.HairLine = "Rounded";
        }
        else if (x >= 35 && x <= 51)
        {
            DataStorage.HairLine = "Widow's Peak";
        }
        else if (x >= 52 && x <= 68)
        {
            DataStorage.HairLine = "Rectangular";
        }
        else if (x >= 69 && x <= 84)
        {
            DataStorage.HairLine = "Receding";
        }
        else if (x >= 85 && x <= 101)
        {
            DataStorage.HairLine =  "Receding peak";
        }
        else
        {
            DataStorage.HairLine = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */
        }
    }

    void SetHairColor()
    {
        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 80)
        {
            DataStorage.HairColor = "Natural";
        }
        else if (x >= 81 && x <= 100)
        {
            DataStorage.HairColor = "Unnatural";
        }
        else
        {
            DataStorage.HairColor = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }

    }

    void SetNaturalShades()
    {
        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 10)
        {
            DataStorage.NaturalShades = "White";
        }
        else if (x >= 11 && x <= 30)
        {
            DataStorage.NaturalShades = "Blonde";
        }
        else if (x >= 31 && x <= 70)
        {
            DataStorage.NaturalShades = "Brunette";
        }
        else if (x >= 71 && x <= 100)
        {
            DataStorage.NaturalShades = "Black";
        }
        else
        {
            DataStorage.HairColor = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }

    }

    void SetNaturalTint()
    {

        int x = Random.Range(0, 101);
        if (x >= 0 && x <= 10)
        {
            DataStorage.NaturalTint = "Strong Red";
        }
        else if (x >= 11 && x <= 30)
        {
            DataStorage.NaturalTint = "Moderate Red";
        }
        else if (x >= 31 && x <= 70)
        {
            DataStorage.NaturalTint = "Weak Red";
        }
        else if (x >= 71 && x <= 100)
        {
            DataStorage.NaturalTint = "No Red";
        }
        else
        {
            DataStorage.NaturalTint = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }
    }

    void SetFaceShape()
    {
        int x = Random.Range(0, 101);
        if (x >= 0 && x <= 17)
        {
            DataStorage.FaceShape =  "Long";
        }
        else if (x >= 18 && x <= 34)
        {
            DataStorage.FaceShape = "Oval";
        }
        else if (x >= 35 && x <= 51)
        {
            DataStorage.FaceShape = "Round";
        }
        else if (x >= 52 && x <= 68)
        {
            DataStorage.FaceShape = "Heart";
        }
        else if (x >= 69 && x <= 84)
        {
            DataStorage.FaceShape = "Diamond";
        }
        else if (x >= 85 && x <= 100)
        {
            DataStorage.FaceShape = "Square";
        }
        else
        {
            DataStorage.NaturalTint = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }
    }

    void SetEyeShape()
    {
        int x = Random.Range(0, 101);
        if (x >= 0 && x <= 14)
        {
            DataStorage.EyeShape = "Deep-Set";
        }
        else if (x >= 15 && x <= 28)
        {
            DataStorage.EyeShape = "Hooded";
        }
        else if (x >= 29 && x <= 42)
        {
            DataStorage.EyeShape = "Drooping";
        }
        else if (x >= 43 && x <= 56)
        {
            DataStorage.EyeShape = "Downturned";
        }
        else if (x >= 57 && x <= 71)
        {
            DataStorage.EyeShape = "Round";
        }
        else if (x >= 72 && x <= 86)
        {
            DataStorage.EyeShape = "Almond";
        }
        else if (x >= 87 && x < 101)
        {
            DataStorage.EyeShape = "Upturned";
        }
        else
        {
            DataStorage.NaturalTint = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }
    }

    void SetEyeColors()
    {

        int x = Random.Range(0, 101);
        if (x >= 0 && x <= 90)
        {
            DataStorage.EyeColor = "Natural";
        }
        else if (x >= 91 && x< 101)
        {
            DataStorage.EyeColor = "Unnatural";
        }
        else
        {
            DataStorage.EyeColor = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }
    }

    void SetEyeColors2()
    {
        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 2)
        {
            DataStorage.EyeColor2 = "Light Grey";
        }
        else if (x >= 3 && x <= 7)
        {
            DataStorage.EyeColor2 = "Grey";
        }
        else if (x >= 8 && x <= 11)
        {
            DataStorage.EyeColor2 = "Pale Blue";
        }
        else if (x >= 12 && x <= 19)
        {
            DataStorage.EyeColor2 = "Blue";
        }
        else if (x >= 20 && x <= 20)
        {
            DataStorage.EyeColor2 =  "Violet";
        }
        else if (x >= 21 && x <= 24)
        {
            DataStorage.EyeColor2 = "Blue-Green";
        }
        else if (x >= 25 && x <= 26)
        {
            DataStorage.EyeColor2 = "Green";
        }
        else if (x >= 27 && x <= 27)
        {
            DataStorage.EyeColor2 = "Amber";
        }
        else if (x >= 28 && x <= 36)
        {
            DataStorage.EyeColor2 = "Hazel";
        }
        else if (x >= 37 && x <= 56)
        {
            DataStorage.EyeColor2 = "Light Brown";
        }
        else if (x >= 57 && x <= 96)
        {
            DataStorage.EyeColor2 = "Dark Brown";
        }
        else if (x >= 97 && x < 101)
        {
            DataStorage.EyeColor2 = "Black";
        }
        else
        {
            DataStorage.EyeColor2 = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }
    }

    void SetAssignedSex()
    {
        int x = Random.Range(0, 101);
        DataStorage.IsIntersex = false;

        if (x >= 0 && x <= 46)
        {
            DataStorage.AssignedSex = "Male";
        }
        else if (x >= 47 && x <= 91)
        {

            DataStorage.AssignedSex = "Female";
        }
        else if (x >= 92 && x <= 100)
        {
            DataStorage.IsIntersex = true;
            DataStorage.AssignedSex = "Intersex";
        }
        else
        {
            DataStorage.AssignedSex = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }

    }

    void SetGenderIdentity()
    {
        int x = Random.Range(0, 101);
        DataStorage.IsNonBinary = false;

        if (DataStorage.IsIntersex) /* This checks if the NPC is intersex. If so, they are more likely to be transgender. */
        {
            x = x + 30;
            x = Mathf.Clamp(x, 1, 100);
      
           
        }

        if (x >= 0 && x <= 50)
        {
            DataStorage.GenderIdentity = "Cisgender";
            DataStorage.TransDenom = "--";
            DataStorage.NonBinaryDenom = "--";
            DataStorage.NonBinaryDenom2 = "--";
        }
        else if (x >= 51 && x < 101)
        {

            int y = Random.Range(1, 101);

            if (y >= 0 && y <= 60)
            {
                DataStorage.GenderIdentity = "Transgender";
                DataStorage.TransDenom = "Binary";
                DataStorage.NonBinaryDenom = "--";
                DataStorage.NonBinaryDenom2 = "--";
                
            }
            else if (y >= 61 && y <= 100)
            {
                int z = Random.Range(1, 101);

                DataStorage.IsNonBinary = true; /* Non-binary NPC */
                if (z >= 0 && z <= 70)
                {
                    DataStorage.GenderIdentity = "Transgender";
                    DataStorage.TransDenom = "Non-Binary";
                    DataStorage.NonBinaryDenom = "Stable";
                    DataStorage.NonBinaryDenom2 = NonBinaryDenom(Random.Range(1, 101));

                    DataStorage.IsNonBinary = true;

    

                }
                else if (z >= 71 && z <= 100)
                {
                    DataStorage.GenderIdentity = "Transgender";
                    DataStorage.TransDenom = "Non-Binary";
                    DataStorage.NonBinaryDenom = "Fluid";
                    DataStorage.NonBinaryDenom2 = NonBinaryDenom(Random.Range(1, 101));

                    DataStorage.IsNonBinary = true;

                }
                else
                {
                    DataStorage.TransDenom = "--";
                    DataStorage.GenderIdentity = "--";
                    DataStorage.NonBinaryDenom = "--";
                    DataStorage.NonBinaryDenom2 = "--";
                    Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable z: " + x);
                    /* Outputs an error log with the function's name and variable x. */
                }


            }
            else
            {

                DataStorage.TransDenom = "--";
                DataStorage.GenderIdentity = "--";
                DataStorage.NonBinaryDenom = "--";
                DataStorage.NonBinaryDenom2 = "--";
                Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable y: " + x);
                /* Outputs an error log with the function's name and variable x. */
            }
        }
        else
        {
            DataStorage.TransDenom = "--";
            DataStorage.GenderIdentity = "--";
            DataStorage.NonBinaryDenom = "--";
            DataStorage.NonBinaryDenom2 = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }

    }

  


    void SetGenderExpression()
    {
        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 70)
        {
            DataStorage.GenderExpression = "Reflects ID";
        }
        else if (x >= 71 && x <= 100)
        {
            DataStorage.GenderExpression = "Not Indicative";
        }
        else
        {
            DataStorage.GenderExpression = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }

    }


    void SetFashion()
    {
        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 20)
        {
            DataStorage.Style =  "Cool";
        }
        else if (x >= 21 && x <= 40)
        {
            DataStorage.Style = "Beauty";
        }
        else if (x >= 41 && x <= 60)
        {
            DataStorage.Style = "Cute";
        }
        else if (x >= 61 && x <= 80)
        {
            DataStorage.Style = "Smart";
        }
        else if (x >= 81 && x <= 100)
        {
            DataStorage.Style = "Tough";
        }
        else
        {
            DataStorage.Style = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }
    }

    void SetRomanticOrientation()
    {
        int x = Random.Range(0, 101);

        if (DataStorage.RomanticType == "Mismatching")
        {
            /* If mismatching, we want to make sure the two values are different */
            if (x >= 0 && x <= 35)
            {
                DataStorage.MismatchingType = "Men/Masc";
            }
            else if (x >= 36 && x <= 70)
            {
                DataStorage.MismatchingType = "Women/Fem";
            }
            else if (x >= 71 && x <= 91)
            {
                DataStorage.MismatchingType = "All";
				return;
            }
            else if (x >= 92 && x <= 100)
            {
                DataStorage.MismatchingType = "Non-binary";
            }
            else
            {
                DataStorage.MismatchingType = "--";

            }

			if(DataStorage.MismatchingType != "All")
			{
				
            do
				{
					x = Random.Range(0, 101);
					if (x >= 0 && x <= 45)
					{
						DataStorage.MismatchingType2 = "Men/Masc";
					}
					else if (x >= 46 && x <= 90)
					{
						DataStorage.MismatchingType2 = "Women/Fem";
					}
					else if (x >= 92 && x <= 100)
					{
						DataStorage.MismatchingType2 = "Non-binary";
					}
					else
					{
						DataStorage.MismatchingType2 = "--";

					}
				}
				while (DataStorage.MismatchingType == DataStorage.MismatchingType2);
			}


        }




    }

    
    void SetSexualOrientation()
    {
        int x = Random.Range(0, 101);
        if (x >= 0 && x <= 35)
        {
            DataStorage.AttractedTo = "Men/Masc";
        }
        else if (x >= 36 && x <= 70)
        {
            DataStorage.AttractedTo = "Women/Fem";
        }
        else if (x >= 71 && x <= 91)
        {
            DataStorage.AttractedTo = "All";
            DataStorage.IsPolysexual = true;
            DataStorage.OrientationType = "Polysexual";
			DataStorage.AttractedTo2 = "--";
			return;
        }
        else if (x >= 92 && x <= 97)
        {
            DataStorage.AttractedTo = "Non-binary";
        }
        else if (x >= 98 && x <= 100)
        {
            DataStorage.IsAsexual = true;
            DataStorage.AttractedTo = "None";
        }
        else
        {
            DataStorage.AttractedTo = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
          

        }

        if(DataStorage.IsPolysexual && DataStorage.AttractedTo != "All")
        {

            do
            {
                x = Random.Range(0, 101);
                if (x >= 0 && x <= 45)
                {
                    DataStorage.AttractedTo2 = "Men/Masc";
                }
                else if (x >= 46 && x <= 90)
                {
                    DataStorage.AttractedTo2 = "Women/Fem";
                }
                else if (x >= 91 && x <= 100)
                {
                    DataStorage.AttractedTo2 = "Non-binary";
                }
                else
                {
                    DataStorage.AttractedTo2 = "--";

                }
            }
            while (DataStorage.AttractedTo == DataStorage.AttractedTo2);

            //Debug.Log("Polysexual");
            //Debug.Log(DataStorage.AttractedTo + " " + DataStorage.AttractedTo2);


        }
        

    }





    void SetOrientationType()
    {
        DataStorage.IsAsexual = false;
        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 90)
        {
            DataStorage.OrientationType = "Monosexual";
            DataStorage.IsPolysexual = false;
            SetSexualOrientation();
        }
        else if (x >= 91 && x <= 100)
        {            
            DataStorage.OrientationType = "Polysexual";
            DataStorage.IsPolysexual = true;
            SetSexualOrientation();
        }
        else
        {
            DataStorage.OrientationType = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */
        }
    }


 
    void SetRomanticType()
    {
        int x = Random.Range(0, 101);
        if (DataStorage.IsAsexual)
        {
            x = x + 60;
            x = Mathf.Clamp(x, 1, 100);
        }

        if (x >= 0 && x <= 90)
        {
            DataStorage.RomanticType = "Matching";
        }
        else if (x >= 91 && x < 101)
        {
            DataStorage.RomanticType = "Mismatching";
            SetRomanticOrientation();
            //Debug.Log(DataStorage.MismatchingType + " " + DataStorage.MismatchingType2);

        }
        else
        {
            DataStorage.RomanticType = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */
        }

    }



    void SetBrowPlacement()
    {
        int x = Random.Range(0, 101);
        if (x >= 0 && x <= 33)
        {
            DataStorage.BrowPlacement = "High";
        }
        else if (x >= 34 && x <= 66)
        {
            DataStorage.BrowPlacement = "Median";
        }
        else if (x >= 67 && x <= 100)
        {
            DataStorage.BrowPlacement = "Low";
        }
        else
        {
            DataStorage.RomanticType = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }

    }

    void SetBrowShape()
    {
        int x = Random.Range(0, 101);
        if (x >= 0 && x <= 20)
        {
            DataStorage.BrowShape = "Curved";
        }
        else if (x >= 21 && x <= 40)
        {
            DataStorage.BrowShape = "Angled";
        }
        else if (x >= 41 && x <= 60)
        {
            DataStorage.BrowShape = "Soft Angled";
        }
        else if (x >= 61 && x <= 80)
        {
            DataStorage.BrowShape = "Rounded";
        }
        else if (x >= 81 && x < 101)
        {
            DataStorage.BrowShape = "Flat";
        }
        else
        {
            DataStorage.BrowShape = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }
    }

    void SetNoseBridge()
    {
        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 33)
        {
            DataStorage.NoseBridge = "Prominent";
        }
        else if (x >= 34 && x <= 66)
        {
            DataStorage.NoseBridge = "Median";
        }
        else if (x >= 67 && x <= 100)
        {
            DataStorage.NoseBridge = "Flat";
        }
        else
        {
            DataStorage.NoseBridge = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }

    }

    void SetNoseTipDirection()
    {
        int x = Random.Range(0, 101);
        if (x >= 0 && x <= 33)
        {
            DataStorage.NoseTip = "Upturned";
        }
        else if (x >= 34 && x <= 66)
        {
            DataStorage.NoseTip = "Straight";
        }
        else if (x >= 67 && x <= 100)
        {
            DataStorage.NoseTip = "Downturned";
        }
        else
        {

            DataStorage.NoseTip = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }

    }

    void SetNoseWings()
    {
        int x = Random.Range(0, 101);
        if (x >= 0 && x <= 33)
        {
            DataStorage.NoseWing = "Flared";
        }
        else if (x >= 34 && x <= 66)
        {
            DataStorage.NoseWing = "Median";
        }
        else if (x >= 67 && x <= 100)
        {
            DataStorage.NoseWing = "Narrow";
        }
        else
        {
            DataStorage.NoseWing = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }

    }

    void SetLipShape()
    {
        int x = Random.Range(0, 101);
        if (x >= 0 && x <= 33)
        {
            DataStorage.LipShape = "Wide";
        }
        else if (x >= 34 && x <= 66)
        {
            DataStorage.LipShape = "Median";
        }
        else if (x >= 67 && x <= 100)
        {
            DataStorage.LipShape = "Short";
        }
        else
        {
            DataStorage.LipShape = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }

    }

    void SetLipThickness()
    {
        int x = Random.Range(0, 101);
        if (x >= 0 && x <= 33)
        {
            DataStorage.LipThickness = "Full";
        }
        else if (x >= 34 && x <= 66)
        {
            DataStorage.LipThickness = "Median";
        }
        else if (x >= 67 && x <= 100)
        {
            DataStorage.LipThickness = "Thin";
        }
        else
        {
            DataStorage.LipThickness = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }

    }

    void SetCupidsBow()
    {
        int x = Random.Range(0, 101);
        if (x >= 0 && x <= 30)
        {
            DataStorage.CupidsBow = "Wide";
        }
        else if (x >= 31 && x <= 60)
        {
            DataStorage.CupidsBow = "Median";
        }
        else if (x >= 61 && x <= 90)
        {
            DataStorage.CupidsBow = "Narrow";
        }
        else if (x >= 91 && x < 101)
        {
            DataStorage.CupidsBow = "None";
        }
        else
        {
            DataStorage.CupidsBow = "--";
            Debug.Log("Problem with function " + System.Reflection.MethodBase.GetCurrentMethod().Name + " and variable x: " + x);
            /* Outputs an error log with the function's name and variable x. */

        }

    }

    #endregion









    void UpdateText()
    {



        /*
        text.text =     "\tMetabolism: \t\t\t" + Metabolism(Random.Range(1, 101)) + "\n" +
                        "\tBody Type: \t\t\t" + BodyType(Random.Range(1, 101)) + "\n" +
                        "\tBreast Type: \t\t\t" + BreastType(Random.Range(1, 101)) + "\n" +
                        "\tSkin Tone: \t\t\t" + SkinTone(Random.Range(1, 101)) + "\n" +
                        "\tSkin Color: \t\t\t" + SkinColor(Random.Range(1, 101)) + "\n" +
                        "\tHair Type: \t\t\t\t" + HairType(Random.Range(1, 101)) + "\n" +
                        "\tHairline Shape: \t" + HairlineShape(Random.Range(1, 101)) + "\n" +
                        "\tHair Color: \t\t\t" + HairColor(Random.Range(1, 101)) + "\n" +
                        "\tNatural Shades: \t" + NaturalShades(Random.Range(1, 101)) + "\n" +
                        "\tNatural Tint: \t\t\t" + NaturalTint(Random.Range(1, 101)) + "\n" +
                        "\tFace Shape: \t\t\t" + FaceShape(Random.Range(1, 101)) + "\n" +
                        "\tEye Shape: \t\t\t" + EyeShape(Random.Range(1, 101)) + "\n" +
                        "\tEye Color Type: \t" + EyeColor(Random.Range(1, 101)) + "\n" +
                        "\tEye Color: \t\t\t\t" + EyeColor2(Random.Range(1, 101)) + "\n";


        text2.text =    "\tBrow Placement: \t\t\t" + BrowPlacement(Random.Range(1, 101)) + "\n" +
                        "\tBrow Shape: \t\t\t\t" + BrowShape(Random.Range(1, 101)) + "\n" +
                        "\tNose Bridge: \t\t\t\t" + NoseBridge(Random.Range(1, 101)) + "\n" +
                        "\tNose Tip: \t\t\t\t\t\t" + NoseTipDirection(Random.Range(1, 101)) + "\n" +
                        "\tNose Wings: \t\t\t\t\t" + NoseWings(Random.Range(1, 101)) + "\n" +
                        "\tShape: \t\t\t\t\t\t\t" + LipShape(Random.Range(1, 101)) + "\n" +
                        "\tLip Shape cont.: \t\t\t" + LipShape2(Random.Range(1, 101)) + "\n" +
                        "\tCupid's Bow: \t\t\t\t" + CupidsBow(Random.Range(1, 101)) + "\n" +
                        "\tAssigned Sex: \t\t\t\t" + AssignedSex(Random.Range(1, 101)) + "\n" +
                        "\tGender Identity: \t\t\t" + GenderIdentity(Random.Range(1, 101)) + "\n" +
                        "\tGender Expression: \t" + GenderExpression(Random.Range(1, 101)) + "\n" +
                        "\tRomantic Orientation: " + Orientation2(Random.Range(1, 101)) + "\n" +
                        "\tSexual Orientation: \t\t" + Orientation1(Random.Range(1, 101)) + "\n" +
                        "\tFashion: \t\t\t\t\t\t" + Fashion(Random.Range(1, 101)) + "\n";

    */
    }


    #region NPC Attribute Roll Functions, String returns

    string BreastType(int x)
    {
        if (x >= 0 && x <= 5)
        {
            return "None";
        }
        else if (x >= 6 && x <= 30)
        {
            return "Flat";
        }
        else if (x >= 31 && x <= 60)
        {
            return "Swooping";
        }
        else if (x >= 61 && x <= 90)
        {
            return "Hanging";
        }
        else if (x >= 91 && x < 101)
        {
            return "Tube";
        }
        else
        {
            return x + " Something went wrong.";

        }
    }

    string SkinTone(int x)
    {
        if (x >= 0 && x <= 33)
        {
            return "Cool";
        }
        else if (x >= 34 && x <= 66)
        {
            return "Neutral";
        }
        else if (x >= 67 && x <= 101)
        {
            return "Warm";
        }
        else
        {
            return x + " Something went wrong.";
        }
    }

    string SkinColor(int x)
    {
        if (x >= 0 && x <= 20)
        {
            return "Very Light";
        }
        else if (x >= 21 && x <= 40)
        {
            return "Light";
        }
        else if (x >= 41 && x <= 60)
        {
            return "Medium";
        }
        else if (x >= 61 && x <= 80)
        {
            return "Dark";
        }
        else if (x >= 81 && x < 101)
        {
            return "Very Dark";
        }
        else
        {
            return x + " Something went wrong.";

        }
    }

    string HairType(int x)
    {
        if (x >= 0 && x <= 13)
        {
            return "Straight";
        }
        else if (x >= 14 && x <= 26)
        {
            return "Low Wave";
        }
        else if (x >= 27 && x <= 39)
        {
            return "High Wave";
        }
        else if (x >= 40 && x <= 52)
        {
            return "Loose Curls";
        }
        else if (x >= 53 && x <= 64)
        {
            return "Tight Curls";
        }
        else if (x >= 65 && x <= 76)
        {
            return "S-type Frizz";
        }
        else if (x >= 77 && x <= 88)
        {
            return "Z-type Frizz";
        }
        else if (x >= 89 && x < 101)
        {
            return "Peppercorn";
        }
        else
        {
            return x + " Something went wrong.";

        }
    }

    string HairlineShape(int x)
    {
        if (x >= 0 && x <= 17)
        {
            return "Straight";
        }
        else if (x >= 18 && x <= 34)
        {
            return "Rounded";
        }
        else if (x >= 35 && x <= 51)
        {
            return "Widow's Peak";
        }
        else if (x >= 52 && x <= 68)
        {
            return "Rectangular";
        }
        else if (x >= 69 && x <= 84)
        {
            return "Receding";
        }
        else if (x >= 85 && x <= 101)
        {
            return "Receding peak";
        }
        else
        {
            return x + " Something went wrong.";

        }
    }

    string HairColor(int x)
    {

        if (x >= 0 && x <= 80)
        {
            return "Natural";
        }
        else if (x >= 81 && x < 101)
        {
            return "Unnatural";
        }
        {
            return x + " Something went wrong.";

        }

    }

    string NaturalShades(int x)
    {

        if (x >= 0 && x <= 10)
        {
            return "White";
        }
        else if (x >= 11 && x <= 30)
        {
            return "Blonde";
        }
        else if (x >= 31 && x <= 70)
        {
            return "Brunette";
        }
        else if (x >= 71 && x < 101)
        {
            return "Black";
        }
        else
        {
            return x + " Something went wrong.";

        }

    }

    string NaturalTint(int x)
    {
        if (x >= 0 && x <= 5)
        {
            return "Strong Red";
        }
        else if (x >= 6 && x <= 12)
        {
            return "Moderate Red";
        }
        else if (x >= 13 && x <= 20)
        {
            return "Weak Red";
        }
        else if (x >= 11 && x < 101)
        {
            return "No Red";
        }
        else
        {
            return x + " Something went wrong.";

        }
    }

    string FaceShape(int x)
    {
        if (x >= 0 && x <= 17)
        {
            return "Long";
        }
        else if (x >= 18 && x <= 34)
        {
            return "Oval";
        }
        else if (x >= 35 && x <= 51)
        {
            return "Round";
        }
        else if (x >= 52 && x <= 68)
        {
            return "Heart";
        }
        else if (x >= 69 && x <= 84)
        {
            return "Diamond";
        }
        else if (x >= 85 && x < 101)
        {
            return "Square";
        }
        else
        {
            return x + " Something went wrong.";

        }
    }

    string EyeShape(int x)
    {
        if (x >= 0 && x <= 14)
        {
            return "Deep-Set";
        }
        else if (x >= 15 && x <= 28)
        {
            return "Hooded";
        }
        else if (x >= 29 && x <= 42)
        {
            return "Drooping";
        }
        else if (x >= 43 && x <= 56)
        {
            return "Downturned";
        }
        else if (x >= 57 && x <= 71)
        {
            return "Round";
        }
        else if (x >= 72 && x <= 86)
        {
            return "Almond";
        }
        else if (x >= 87 && x < 101)
        {
            return "Upturned";
        }
        else
        {
            return x + " Something went wrong.";

        }
    }

    string EyeColor(int x)
    {
        if (x >= 0 && x <= 90)
        {
            return "Natural";
        }
        else if (x >= 91 && x < 101)
        {
            return "Unnatural";
        }
        else
        {
            return x + " Something went wrong.";

        }
    }

    string EyeColor2(int x)
    {
        if (x >= 0 && x <= 2)
        {
            return "Light Grey";
        }
        else if (x >= 3 && x <= 7)
        {
            return "Grey";
        }
        else if (x >= 8 && x <= 11)
        {
            return "Pale Blue";
        }
        else if (x >= 12 && x <= 19)
        {
            return "Blue";
        }
        else if (x >= 20 && x <= 20)
        {
            return "Violet";
        }
        else if (x >= 21 && x <= 24)
        {
            return "Blue-Green";
        }
        else if (x >= 25 && x <= 26)
        {
            return "Green";
        }
        else if (x >= 27 && x <= 27)
        {
            return "Amber";
        }
        else if (x >= 28 && x <= 36)
        {
            return "Hazel";
        }
        else if (x >= 37 && x <= 56)
        {
            return "Light Brown";
        }
        else if (x >= 57 && x <= 96)
        {
            return "Dark Brown";
        }
        else if (x >= 97 && x < 101)
        {
            return "Black";
        }
        else
        {
            return x + " Something went wrong.";

        }
    }

    string BrowPlacement(int x)
    {

        if (x >= 0 && x <= 33)
        {
            return "High";
        }
        else if (x >= 34 && x <= 66)
        {
            return "Median";
        }
        else if (x >= 67 && x <= 100)
        {
            return "Low";
        }
        else
        {
            return x + " Something went wrong.";

        }

    }

    string BrowShape(int x)
    {
        if (x >= 0 && x <= 20)
        {
            return "Curved";
        }
        else if (x >= 21 && x <= 40)
        {
            return "Angled";
        }
        else if (x >= 41 && x <= 60)
        {
            return "Soft Angled";
        }
        else if (x >= 61 && x <= 80)
        {
            return "Rounded";
        }
        else if (x >= 81 && x < 101)
        {
            return "Flat";
        }
        else
        {
            return x + " Something went wrong.";

        }
    }

    string NoseBridge(int x)
    {

        if (x >= 0 && x <= 33)
        {
            return "Prominent";
        }
        else if (x >= 34 && x <= 66)
        {
            return "Median";
        }
        else if (x >= 67 && x <= 100)
        {
            return "Flat";
        }
        else
        {
            return x + " Something went wrong.";

        }

    }

    string NoseTipDirection(int x)
    {

        if (x >= 0 && x <= 33)
        {
            return "Upturned";
        }
        else if (x >= 34 && x <= 66)
        {
            return "Straight";
        }
        else if (x >= 67 && x <= 100)
        {
            return "Downturned";
        }
        else
        {

            Debug.Log("Something went wrong with method " + this.name + " and Variable x = " + x + ".");
            return "Something went wrong.";

        }

    }

    string NoseWings(int x)
    {

        if (x >= 0 && x <= 33)
        {
            return "Flared";
        }
        else if (x >= 34 && x <= 66)
        {
            return "Median";
        }
        else if (x >= 67 && x <= 100)
        {
            return "Narrow";
        }
        else
        {
            return x + " Something went wrong.";

        }

    }

    string LipShape(int x)
    {

        if (x >= 0 && x <= 33)
        {
            return "Wide";
        }
        else if (x >= 34 && x <= 66)
        {
            return "Median";
        }
        else if (x >= 67 && x <= 100)
        {
            return "Short";
        }
        else
        {
            return x + " Something went wrong.";

        }

    }

    string LipShape2(int x)
    {

        if (x >= 0 && x <= 33)
        {
            return "Full";
        }
        else if (x >= 34 && x <= 66)
        {
            return "Median";
        }
        else if (x >= 67 && x <= 100)
        {
            return "Thin";
        }
        else
        {
            return x + " Something went wrong.";

        }

    }

    string CupidsBow(int x)
    {

        if (x >= 0 && x <= 30)
        {
            return "Wide";
        }
        else if (x >= 31 && x <= 60)
        {
            return "Median";
        }
        else if (x >= 61 && x <= 90)
        {
            return "Narrow";
        }
        else if (x >= 91 && x < 101)
        {
            return "None";
        }
        else
        {
            return x + " Something went wrong.";

        }

    }

    string AssignedSex(int x)
    {
        DataStorage.IsIntersex = false;

        if (x >= 0 && x <= 46)
        {
            return "Male";
        }
        else if (x >= 47 && x <= 91)
        {

            return "Female";
        }
        else if (x >= 92 && x < 101)
        {
            DataStorage.IsIntersex = true;
            return "Intersex";
        }
        else
        {
            return x + " Something went wrong.";

        }

    }

    string GenderIdentity(int x)
    {
        DataStorage.IsNonBinary = false;
        if (DataStorage.IsIntersex) /* This checks if the NPC is intersex. If so, they are more likely to be transgender. */
        {
            x = x + 30;
            x = Mathf.Clamp(x, 1, 100);

        }

        if (x >= 0 && x <= 50)
        {
            return "Cisgender";
        }
        else if (x >= 51 && x < 101)
        {

            int y = Random.Range(1, 101);

            if (y >= 0 && y <= 60)
            {
                return "Transgender, binary";
            }
            else if (y >= 61 && y < 101)
            {
                int z = Random.Range(1, 101);

                DataStorage.IsNonBinary = true; /* Non-binary NPC */
                if (z >= 0 && z <= 70)
                {
                    return "Transgender, Non-binary, Stable" + NonBinaryDenom(Random.Range(1, 101));

                }
                else if (z >= 71 && z < 101)
                {
                    return "Transgender, Non-binary, Fluid" + NonBinaryDenom(Random.Range(1, 101));
                }

            }

            return y + "Something went wrong";
        }
        else
        {
            return x + "Something went wrong.";

        }

    }

    string GenderExpression(int x)
    {

        if (x >= 0 && x <= 70)
        {
            return "Reflects ID";
        }
        else if (x >= 71 && x < 101)
        {
            return "Not Indicative";
        }
        else
        {
            return x + " Something went wrong.";

        }

    }

    string NonBinaryDenom(int x)
    {
        x = Random.Range(0,101);
        if (DataStorage.IsNonBinary)
        {
            if (x >= 0 && x <= 30)
            {
                return "Masculine";
            }
            else if (x >= 31 && x <= 38)
            {
                return "Masc/Fem";
            }
            else if (x >= 39 && x <= 45)
            { 
                return "Masc/Neutral";
            }
            else if (x >= 46 && x <= 49)
            {
                return "Neutral/Agender";
            }
            else if (x >= 50 && x <= 55)
            {
                PolyGender();
                return "Polygender: \n" + DataStorage.Polygender + ", " + DataStorage.Polygender2;
            }
            else if (x >= 56 && x <= 62)
            {
                return "Fem/Neutral";
            }
            else if (x >= 63 && x <= 70)
            {
                return "Fem/Masc";
            }
            else if (x >= 71 && x <= 100)
            {
                return "Feminine";
            }
            else
            {
                return x + " Something went wrong.";

            }
        }
        else
        {
            return "";
        }

    }

   

    void PolyGender()
    {
        int x = Random.Range(0, 101);

        if (x >= 0 && x <= 30)
        {
          DataStorage.Polygender = "Masculine";
        }
        else if (x >= 31 && x <= 38)
        {
            DataStorage.Polygender = "Masc /Fem";
        }
        else if (x >= 39 && x <= 45)
        {
            DataStorage.Polygender = "Masc /Neutral";
        }
        else if (x >= 46 && x <= 47)
        {
            DataStorage.Polygender = "Pangender";
        }
        else if (x >= 48 && x <= 55)
        {
            DataStorage.Polygender = "Neutral";
        }
        else if (x >= 56 && x <= 62)
        {
            DataStorage.Polygender = "Fem /Neutral";
        }
        else if (x >= 63 && x <= 70)
        {
            DataStorage.Polygender = "Fem/Masc";
        }
        else if (x >= 71 && x <= 100)
        {
            DataStorage.Polygender = "Feminine";
        }
        else
        {
            DataStorage.Polygender = "--";
        }


      

        do
        {
            x = Random.Range(0, 101);
            if (x >= 0 && x <= 30)
            {
                DataStorage.Polygender2 = "Masculine";
            }
            else if (x >= 31 && x <= 38)
            {
                DataStorage.Polygender2 = "Masc /Fem";
            }
            else if (x >= 39 && x <= 45)
            {
                DataStorage.Polygender2 = "Masc /Neutral";
            }
            else if (x >= 46 && x <= 47)
            {
                DataStorage.Polygender2 = "Pangender";
            }
            else if (x >= 48 && x <= 55)
            {
                DataStorage.Polygender2 = "Neutral";
            }
            else if (x >= 56 && x <= 62)
            {
                DataStorage.Polygender2 = "Fem /Neutral";
            }
            else if (x >= 63 && x <= 70)
            {
                DataStorage.Polygender2 = "Fem/Masc";
            }
            else if (x >= 71 && x <= 100)
            {
                DataStorage.Polygender2 = "Feminine";
            }
            else
            {
                DataStorage.Polygender2 = "--";
            }
        }
        while (DataStorage.Polygender == DataStorage.Polygender2);





    }

   

    /*
    string Orientation1(int x)
    {


        if (x >= 0 && x <= 90)
        {
            return "Mono-attracted, " + SexualOrientation(Random.Range(1, 101));
        }
        else if (x >= 91 && x < 101)
        {
            return "Poly-attracted, " + SexualOrientation(Random.Range(1, 101)) + ", " + SexualOrientation(Random.Range(1, 101));
        }
        else
        {
            return "Something went wrong.";
        }
    }*/
    /*
    string Orientation2(int x)
    {
        if (DataStorage.IsAsexual)
        {
            x = x + 60;
            x = Mathf.Clamp(x, 1, 100);
        }

        if (x >= 0 && x <= 90)
        {
            return "Matching";
        }
        else if (x >= 91 && x < 101)
        {
            SetSexualOrientation();
            return "Mismatching";
        }
        else
        {
            return "Something went wrong.";
        }

    }
    */

  

    string Fashion(int x)
    {
        if (x >= 0 && x <= 20)
        {
            return "Cool";
        }
        else if (x >= 21 && x <= 40)
        {
            return "Beauty";
        }
        else if (x >= 41 && x <= 60)
        {
            return "Cute";
        }
        else if (x >= 61 && x <= 80)
        {
            return "Smart";
        }
        else if (x >= 81 && x < 101)
        {
            return "Tough";
        }
        else
        {
            return x + " Something went wrong.";

        }
    }
    #endregion
}
