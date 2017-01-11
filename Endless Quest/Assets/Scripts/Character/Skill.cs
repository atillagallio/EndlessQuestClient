using System.Collections.Generic;

public class Skill{

	private bool _known;
	private List<int> _cooldown;
	private bool _ative;
	private int _skillLevel;
	private List<int> _skillCost;
	private Level level;

	public Skill ()
	{
		_known = false;
		_cooldown = new List<int> ();
		_ative = false;
		_skillLevel = 1;
	}

	public int SkillLevel {
		get{ return _skillLevel; }
		set{_skillLevel = value; }

	}
	public void AddCooldown(List<int> cd) {
		foreach(int cooldown in cd)
			_cooldown.Add(cooldown);

	}
	public int SkillCost {
		get{ return _skillCost[_skillLevel -1]; }
		set{ _skillCost[_skillLevel -1] = value; }
	}

	public void AddSkillCost(List<int> skillcost) {
		foreach( int skcost in skillcost)
			_skillCost.Add(skcost);

	}
	public int Cooldown {
		get{ return _cooldown[_skillLevel -1]; }
		set{ _cooldown[_skillLevel -1] = value; }
	}

	public bool Ative {
		get{ return _ative; }
		set{ _ative = value; }
	}

	public bool Known {
			get{ return _known; }
			set{ _known = value; }
	}
}

public enum SkillName{
	Melee_Attack,
	Ranged_Attack,
	Double_Strike,
	Hurricane_Shot,
	Last_Wish,
	Sword_Bash,
	Cosmic_Sensation,
	Fireball,
	Holy_Bless,
	Conversion,
	Lifesteal,
	Shadow_Essence,
	Fervor,
	Ultra_Punch,
	Far_Seer,
	Impaling_Shot,
	Wolfs_Howl,
	Get_Your_Prey,
	Endless_Rage,
	Fury,
	Block,
	War_Shout,
	Arcane_Burn,
	Arctic_Explosion,
	Elemental_Favor,
	Soul_Drain,
	Divinity,
	Weakness,
	Serenity,
	Flow,
	Weak_Point,
	Here_I_Go,
	Killing_Blow,
	Bloody_Frenzy,
	Soul_Burn,
	Mana_Dispersion,
	Willpower,
	Awareness

}


