using System.Collections.Generic;
using System;  //enum class

public class Monk : HeroClass
{
	public Monk (){
		this.DerivedFrom = "Priest";
		this.ClassName = "Monk";
		this.ClassTitle = "Saint";
		this.WeaponUsed = "Gloves";
		this.IsDerived = true;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Vitality).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Agility).BaseValue = 1;
		this.GetSkill ((int)SkillName.Serenity).Known = true;
		this.GetSkill ((int)SkillName.Serenity).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Flow).Known = true;
		this.GetSkill ((int)SkillName.Flow).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}

