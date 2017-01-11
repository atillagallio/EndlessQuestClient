using System.Collections.Generic;
using System;  //enum class

public class Soldier : HeroClass
{
	public Soldier (){
		this.ClassName = "Soldier";
		this.ClassTitle = "Battle";
		this.WeaponUsed = "Sword";
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Defense).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Vitality).BaseValue = 1;
		this.GetSkill ((int)SkillName.Last_Wish).Known = true;
		this.GetSkill ((int)SkillName.Last_Wish).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Sword_Bash).Known = true;
		this.GetSkill ((int)SkillName.Sword_Bash).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}

