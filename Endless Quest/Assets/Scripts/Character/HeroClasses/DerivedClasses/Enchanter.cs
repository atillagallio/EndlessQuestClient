using System.Collections.Generic;
using System;  //enum class

public class Enchanter : HeroClass
{
	public Enchanter (){
		this.DerivedFrom = "Mage";
		this.ClassName = "Enchanter";
		this.ClassTitle = "Elemental";
		this.WeaponUsed = "Staff";
		this.IsDerived = true;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Intelligence).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Agility).BaseValue = 1;
		this.GetSkill ((int)SkillName.Elemental_Favor).Known = true;
		this.GetSkill ((int)SkillName.Elemental_Favor).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Soul_Drain).Known = true;
		this.GetSkill ((int)SkillName.Soul_Drain).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}

