using System.Collections.Generic;
using System;  //enum class

public class Priest : HeroClass
{
	public Priest (){
		this.ClassName = "Priest";
		this.ClassTitle = "Holy";
		this.WeaponUsed = "Mace";
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Intelligence).BaseValue = 2;
		this.GetSkill ((int)SkillName.Holy_Bless).Known = true;
		this.GetSkill ((int)SkillName.Holy_Bless).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Conversion).Known = true;
		this.GetSkill ((int)SkillName.Conversion).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}