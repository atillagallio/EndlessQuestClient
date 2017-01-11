using System.Collections.Generic;
using System;  //enum class

public class Warrior : HeroClass
{
	public Warrior (){
		this.DerivedFrom = "Soldier";
		this.ClassName = "Warrior";
		this.ClassTitle = "Lord";
		this.WeaponUsed = "Spear";
		this.IsDerived = true;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Vitality).BaseValue = 2;
		this.GetSkill ((int)SkillName.Block).Known = true;
		this.GetSkill ((int)SkillName.Block).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.War_Shout).Known = true;
		this.GetSkill ((int)SkillName.War_Shout).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}

