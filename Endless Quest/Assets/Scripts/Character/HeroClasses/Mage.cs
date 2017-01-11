using System.Collections.Generic;
using System;  //enum class

public class Mage : HeroClass
{
	public Mage (){
		this.ClassName = "Mage";
		this.ClassTitle = "Arcane";
		this.WeaponUsed = "Wand";
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Intelligence).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Vitality).BaseValue = 1;
		this.GetSkill ((int)SkillName.Cosmic_Sensation).Known = true;
		this.GetSkill ((int)SkillName.Cosmic_Sensation).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Fireball).Known = true;
		this.GetSkill ((int)SkillName.Fireball).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}