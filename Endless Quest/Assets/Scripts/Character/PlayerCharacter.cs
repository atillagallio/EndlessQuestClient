using UnityEngine;
using System.Collections.Generic;
using System;  //enum class

public class PlayerCharacter : BaseCharacter
{
	private Level _level;
	private int i = 0;
	private String _characterTitle;
	private TitleGenerator _titlegen;
	private int _freeAttributePoints;
	String plist;
	String slist;

	public override void Awake()
	{
		base.Awake();
		_freeAttributePoints = 0;
		_level = new Level ();

	}

	public void AddAttribute(int value, int att) {
		if (_freeAttributePoints >= value) {
			_primaryAttribute [att].BonusValue += value;
			_freeAttributePoints -= value;

			CharacterInfoUpdate ();

			GetSecondaryAttManager.SetupSecAttributesModifiers (this);
		}
	}

	public void AddFreeAttributePoints(int value) {
		_freeAttributePoints += value;
	}



	public override void Update()
	{

		if (i == 0) {

			HeroClasses.Add (new Thief ());

			HeroClasses.Add (new Thief ());

			HeroClasses.Add (new Thief ());

			CharacterInfoUpdate();

			Debug.Log (_characterTitle);


		}
		if (i == 20 ) {
			_level.AddExp (800000, this);
			AddAttribute (_freeAttributePoints, (int)PrimaryAttributeName.Agility);

			Debug.LogFormat("Level {0}, {1} Points Available ", _level.CurrentLevel , _freeAttributePoints);
			foreach (Attribute att in PrimaryAttributeList) {
				plist = string.Concat(plist, att.AdjustedBaseValue.ToString()) + ", ";
			}
			Debug.Log (plist);
			foreach (SecondaryAttribute att in SecondaryAttributeList) {
				slist = string.Concat(slist, att.CurValue.ToString()) + ", ";
			}
			Debug.Log (slist);

		}

		i++;
	}
		
	public void CharacterInfoUpdate() {
		for (int cnt = 0; cnt < _skill.Length; cnt++) {
			foreach (HeroClass atthero in _heroClasses) {

				if (atthero.GetSkill (cnt).Known & _skill [cnt].Known)
					_skill [cnt].SkillLevel += 1;
				_skill[cnt].Known = (atthero.GetSkill(cnt).Known | _skill[cnt].Known);
			}
		}

		for (int cnt = 0; cnt < _primaryAttribute.Length; cnt++) {
			_primaryAttribute [cnt].BaseValue = 0;
			foreach (HeroClass atthero in _heroClasses) {
				_primaryAttribute [cnt].BaseValue += atthero.GetPrimaryAttribute (cnt).BaseValue;
			}
		}

		_titlegen = new TitleGenerator(_heroClasses); 
		_characterTitle = _titlegen._characterTitle;

	}


}


