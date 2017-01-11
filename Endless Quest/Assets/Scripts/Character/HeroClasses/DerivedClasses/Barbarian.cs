using System.Collections.Generic;
using System;  //enum class

public class Barbarian : HeroClass
{
	public Barbarian (){
		this.DerivedFrom = "Soldier";
		this.ClassName = "Barbarian";
		this.ClassTitle = "War";
		this.WeaponUsed = "Axe";
		this.IsDerived = true;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Strength).BaseValue = 2;
		this.GetSkill ((int)SkillName.Endless_Rage).Known = true;
		this.GetSkill ((int)SkillName.Endless_Rage).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Fury).Known = true;
		this.GetSkill ((int)SkillName.Fury).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}

