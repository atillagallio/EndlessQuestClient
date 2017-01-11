using System.Collections.Generic;
using System;  //enum class

public class Archer : HeroClass
{
	public Archer (){
		this.ClassName = "Archer";
		this.ClassTitle = "Royal";
		this.WeaponUsed = "Bow";
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Dexterity).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Vitality).BaseValue = 1;
		this.GetSkill ((int)SkillName.Double_Strike).Known = true;
		this.GetSkill ((int)SkillName.Double_Strike).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Hurricane_Shot).Known = true;
		this.GetSkill ((int)SkillName.Hurricane_Shot).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}

