using UnityEngine;
using System.Collections.Generic;
using System;  //enum class

public class BaseCharacter : MonoBehaviour{
	public string _name;
	public List<HeroClass> _heroClasses;
	protected Attribute[] _primaryAttribute;
	protected Skill[] _skill;
	protected SecondaryAttribute[] _secondaryAttribute;
	protected SecondaryAttManager _secondaryAttManager;

	public List<HeroClass> HeroClasses{
		get{ return _heroClasses;}
		set {_heroClasses = value;}
	}

	public virtual void Awake() {
		_name = string.Empty;
		_skill = new Skill[Enum.GetValues (typeof(SkillName)).Length];
		_secondaryAttribute = new SecondaryAttribute[Enum.GetValues(typeof(SecondaryAttributeName)).Length];
		_primaryAttribute = new Attribute[Enum.GetValues(typeof(PrimaryAttributeName)).Length];
		_heroClasses = new List<HeroClass> ();
		_heroClasses.Add(new None());
		SetupAttributesSum();
		SetupSkills();
		_secondaryAttManager = new SecondaryAttManager (this); 

	}

	public virtual void Update() {
	}

	public Attribute[] PrimaryAttributeList{

		get{ return _primaryAttribute; }
	}

	public SecondaryAttribute[] SecondaryAttributeList{

		get{ return _secondaryAttribute; }
		set{ _secondaryAttribute = value;}
	}

	public SecondaryAttribute GetSecondaryAttribute(int index){
		return _secondaryAttribute[index];
	}

	public Attribute GetPrimaryAttribute(int index){
		return _primaryAttribute[index];
	}

	public SecondaryAttManager GetSecondaryAttManager
	{
		get{return _secondaryAttManager;}
	}

	public void SetupAttributesSum() {

		for (int cnt = 0; cnt < _primaryAttribute.Length; cnt++) {
			_primaryAttribute[cnt] = new Attribute();

			foreach (HeroClass atthero in _heroClasses) {
				_primaryAttribute[cnt].BaseValue += atthero.GetPrimaryAttribute(cnt).BaseValue;
			}
		}
	}

	private void SetupSkills(){
		for (int cnt = 0; cnt < _skill.Length; cnt++) {
			_skill[cnt] = new Skill();

			foreach (HeroClass atthero in _heroClasses) {
				_skill[cnt].Known = (atthero.GetSkill(cnt).Known | _skill[cnt].Known);
			}
		}
		SetupSkillModifiers ();
	}
		

	private void SetupSkillModifiers() {

	}
		

}


