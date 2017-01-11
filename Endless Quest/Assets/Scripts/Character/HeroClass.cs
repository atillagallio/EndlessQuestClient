using System;

public class HeroClass
{
	private string _className;
	private string _classTitle;
	private Attribute[] _primaryAttribute;
	private Skill[] _skill;
	private string _weaponUsed;
	private bool _isDerived;
	private string _derivedFrom;

	public HeroClass ()
	{
		_primaryAttribute = new Attribute[Enum.GetValues(typeof(PrimaryAttributeName)).Length];
		_skill = new Skill[Enum.GetValues(typeof(SkillName)).Length];
		_derivedFrom = string.Empty;
		_isDerived = false;

		SetupSkills ();
		SetupPrimaryAttributes ();
	}
		
	public string ClassName {
		get{ return _className; }
		set{ _className = value; }
	}

	public bool IsDerived {
		get{ return _isDerived; }
		set{ _isDerived = value; }
	}

	public string DerivedFrom {
		get{ return _derivedFrom; }
		set{ _derivedFrom = value; }
	}

	public string ClassTitle {
		get{ return _classTitle; }
		set{ _classTitle = value; }
	}
		
	public string WeaponUsed {
		get{ return _weaponUsed; }
		set{ _weaponUsed = value; }
	}

	private void SetupPrimaryAttributes() {
		for (int cnt = 0; cnt < _primaryAttribute.Length; cnt++) {
			_primaryAttribute[cnt] = new Attribute();
		}
	}
	private void SetupSkills(){

		for (int cnt = 0; cnt < _skill.Length; cnt++) {
			_skill[cnt] = new Skill();
		}
	}
	public Attribute GetPrimaryAttribute(int index){
		return _primaryAttribute[index];
	}
	public Skill GetSkill(int index){
		return _skill [index];
	}
		
}

public enum HeroClassName {
	None,
	Archer,
	Sniper,
	Hunter,
	Soldier,
	Barbarian,
	Warrior,
	Mage,
	Spellweaver,
	Enchanter,
	Priest,
	Cleric,
	Monk,
	Thief,
	Explorer,
	Assassin,
	Fighter,
	Neutralist,
	Duelist
}


