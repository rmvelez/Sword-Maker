using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwordMaker : MonoBehaviour
{
	// these four objects are the pieces of the sword that the player can modify
	public GameObject Ball;
	public GameObject Hilt;
	public GameObject Guard;
	public GameObject Blade;

	// these four vars allow us to acess the images for the parts of the sword
	public Image ballImage;
	public Image hiltImage;
	public Image guardImage;
	public Image bladeImage;

	// these four vars allow us to change the color of the various parts of the sword
	public Color32 newBallColor;
	public Color32 newHiltColor;
	public Color32 newGuardColor;
	public Color32 newBladeColor;

	// these sliders are used to adjust the size and color of the four parts of the sword
	public Slider BallSizeSlider;
	public Slider BallColorSlider;
	public Slider HiltSizeSlider;
	public Slider HiltColorSlider;
	public Slider GuardSizeSlider;
	public Slider GuardColorSlider;
	public Slider BladeSizeSlider;
	public Slider BladeColorSlider;

	public Button randBtn; // this slot is for the button that randomizes the components of the sword parts at once
	public Button dnBtn; // slot for the button that players press when they are finished making their sword

	// randomizes the appearence of the sword
	public void RandomizeAppearence()
	{
		// places a random value into each slider
		BallSizeSlider.value = Random.Range(1,2f);
		BallColorSlider.value = Random.Range(1,2f);
		HiltSizeSlider.value = Random.Range(1,2f);
		HiltColorSlider.value = Random.Range(1,2f);
		GuardSizeSlider.value = Random.Range(1,2f);
		GuardColorSlider.value = Random.Range(1,2f);
		BladeSizeSlider.value = Random.Range(1,2f);
		BladeColorSlider.value = Random.Range(1,2f);
	}

	// loads the scene where the player encounters the monster
	public void BeginFight()
	{
		SceneManager.LoadScene("FightScene");
	}

	// this function changes the value of the ball's size based on the slider
	public void BallSizeSliderUpdate()
	{
		// this var holds the current value of the ball size slider
		float newBallSizeValue = BallSizeSlider.value;

		// sets the x and y scale of the ball to the current value of the new var
		Ball.transform.localScale = new Vector2 (newBallSizeValue,newBallSizeValue);
	}

	// this function changes the color of the ball based on the slider
	public void BallColorSliderUpdate()
	{
		// looks for the image on the ball
		ballImage = Ball.GetComponent<Image>();

		// creates a new color pallete for the ball
		newBallColor = new Color32(
			(byte)Random.Range(0,255), //R
			(byte)Random.Range(0,255), //B
			(byte)Random.Range(0,255), //G
			(byte)Random.Range(0,255)); //A

		// sets the color of the ball to the new color var, as determined by the slider
		ballImage.color = newBallColor;
	}

	// this function changes the value of the hilt's size based on the slider
	public void HiltSizeSliderUpdate()
	{
		// this var holds the current value of the hilt size slider
		float newHiltSizeValue = HiltSizeSlider.value;

		// sets the x and y scale of the hilt of the sword to the current value of the new var
		Hilt.transform.localScale = new Vector2 (newHiltSizeValue,newHiltSizeValue);
	}

	// this function changes the color of the hilt based on the slider
	public void HiltColorSliderUpdate()
	{
		// looks for the image on the hilt
		hiltImage = Hilt.GetComponent<Image>();

		// creates a new color pallete for the hilt
		newHiltColor = new Color32(
			(byte)Random.Range(0,255), //R
			(byte)Random.Range(0,255), //B
			(byte)Random.Range(0,255), //G
			(byte)Random.Range(0,255)); //A

		// sets the color of the hilt to the new color var, as determined by the slider
		hiltImage.color = newHiltColor;
	}

	// this function changes the value of the guard's size based on the slider
	public void GuardSizeSliderUpdate()
	{
		// this var holds the current value of the guard size slider
		float newGuardSizeValue = GuardSizeSlider.value;

		// sets the x and y scale of the guard to the current value of the new var
		Guard.transform.localScale = new Vector2 (newGuardSizeValue,newGuardSizeValue);
	}

	// this function changes the color of the ball based on the slider
	public void GuardColorSliderUpdate()
	{
		// looks for the image on the ball
		guardImage = Guard.GetComponent<Image>();

		// creates a new color pallete for the ball
		newGuardColor = new Color32(
			(byte)Random.Range(0,255), //R
			(byte)Random.Range(0,255), //B
			(byte)Random.Range(0,255), //G
			(byte)Random.Range(0,255)); //A

		// sets the color of the guard to the new color var, as determined by the slider
		guardImage.color = newGuardColor;
	}

	// this function changes the value of the blade's size based on the slider
	public void BladeSizeSliderUpdate()
	{
		// this var holds the current value of the blade size slider
		float newBladeSizeValue = BladeSizeSlider.value;

		// sets the x and y scale of the blade to the current value of the new var
		Blade.transform.localScale = new Vector2 (newBladeSizeValue,newBladeSizeValue);
	}

	// this function changes the color of the blade based on the slider
	public void BladeColorSliderUpdate()
	{
		// looks for the image on the blade
		bladeImage = Blade.GetComponent<Image>();

		// creates a new color pallete for the ball
		newBladeColor = new Color32(
			(byte)Random.Range(0,255), //R
			(byte)Random.Range(0,255), //B
			(byte)Random.Range(0,255), //G
			(byte)Random.Range(0,255)); //A

		// sets the color of the blade to the new color var, as determined by the slider
		bladeImage.color = newBladeColor;
	}
}
