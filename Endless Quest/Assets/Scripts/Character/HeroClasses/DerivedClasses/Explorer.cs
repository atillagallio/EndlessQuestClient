using System.Collections.Generic;
using System;  //enum class

public class Explorer : HeroClass
{
	public Explorer (){
		this.DerivedFrom = "Thief";
		this.ClassName = "Explorer";
		this.ClassTitle = "Adventurous";
		this.WeaponUsed = "Whip";
		this.IsDerived = true;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Strength).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Defense).BaseValue = 1;
		this.GetSkill ((int)SkillName.Weak_Point).Known = true;
		this.GetSkill ((int)SkillName.Weak_Point).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Here_I_Go).Known = true;
		this.GetSkill ((int)SkillName.Here_I_Go).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}

