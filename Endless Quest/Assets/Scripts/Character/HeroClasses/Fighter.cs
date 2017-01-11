using System.Collections.Generic;
using System;  //enum class

public class Fighter : HeroClass
{
	public Fighter (){
		this.ClassName = "Fighter";
		this.ClassTitle = "Furious";
		this.WeaponUsed = "Knuckles";
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Strength).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Vitality).BaseValue = 1;
		this.GetSkill ((int)SkillName.Fervor).Known = true;
		this.GetSkill ((int)SkillName.Fervor).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Ultra_Punch).Known = true;
		this.GetSkill ((int)SkillName.Ultra_Punch).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}