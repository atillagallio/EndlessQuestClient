using System.Collections.Generic;
using System;  //enum class

public class Thief : HeroClass
{
	public Thief (){
		this.ClassName = "Thief";
		this.ClassTitle = "Shadow";
		this.WeaponUsed = "Dagger";
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Agility).BaseValue = 2;
		this.GetSkill ((int)SkillName.Lifesteal).Known = true;
		this.GetSkill ((int)SkillName.Lifesteal).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Shadow_Essence).Known = true;
		this.GetSkill ((int)SkillName.Shadow_Essence).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}