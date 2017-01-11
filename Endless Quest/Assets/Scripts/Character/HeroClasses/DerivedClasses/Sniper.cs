using System.Collections.Generic;
using System;  //enum class

public class Sniper : HeroClass
{
	public Sniper (){
		this.DerivedFrom = "Archer";
		this.ClassName = "Sniper";
		this.ClassTitle = "Ranger";
		this.WeaponUsed = "Long Bow";
		this.IsDerived = true;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Dexterity).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Strength).BaseValue = 1;
		this.GetSkill ((int)SkillName.Far_Seer).Known = true;
		this.GetSkill ((int)SkillName.Far_Seer).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Impaling_Shot).Known = true;
		this.GetSkill ((int)SkillName.Impaling_Shot).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}

