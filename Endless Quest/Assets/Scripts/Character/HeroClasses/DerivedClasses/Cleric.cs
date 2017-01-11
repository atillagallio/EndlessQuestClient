using System.Collections.Generic;
using System;  //enum class

public class Cleric : HeroClass
{
	public Cleric (){
		this.DerivedFrom = "Priest";
		this.ClassName = "Cleric";
		this.ClassTitle = "Sacred";
		this.WeaponUsed = "Rosary";
		this.IsDerived = true;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Intelligence).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Defense).BaseValue = 1;
		this.GetSkill ((int)SkillName.Divinity).Known = true;
		this.GetSkill ((int)SkillName.Divinity).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Weakness).Known = true;
		this.GetSkill ((int)SkillName.Weakness).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}

