using System.Collections.Generic;
using System;  //enum class

public class Duelist : HeroClass
{
	public Duelist (){
		this.DerivedFrom = "Fighter";
		this.ClassName = "Duelist";
		this.ClassTitle = "Hex";
		this.WeaponUsed = "Glaive";
		this.IsDerived = true;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Agility).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Defense).BaseValue = 1;
		this.GetSkill ((int)SkillName.Willpower).Known = true;
		this.GetSkill ((int)SkillName.Willpower).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Awareness).Known = true;
		this.GetSkill ((int)SkillName.Awareness).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}
