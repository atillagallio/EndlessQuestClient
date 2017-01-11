using System.Collections.Generic;
using System;  //enum class

public class Neutralist : HeroClass
{
	public Neutralist (){
		this.DerivedFrom = "Fighter";
		this.ClassName = "Neutralist";
		this.ClassTitle = "Neutral";
		this.WeaponUsed = "Nunchaku";
		this.IsDerived = true;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Strength).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Intelligence).BaseValue = 1;
		this.GetSkill ((int)SkillName.Soul_Burn).Known = true;
		this.GetSkill ((int)SkillName.Soul_Burn).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Mana_Dispersion).Known = true;
		this.GetSkill ((int)SkillName.Mana_Dispersion).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}
	