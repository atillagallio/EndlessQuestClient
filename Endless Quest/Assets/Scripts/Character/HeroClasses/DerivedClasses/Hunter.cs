using System.Collections.Generic;
using System;  //enum class

public class Hunter : HeroClass
{
	public Hunter (){
		this.DerivedFrom = "Archer";
		this.ClassName = "Hunter";
		this.ClassTitle = "Forest";
		this.WeaponUsed = "CrossBow";
		this.IsDerived = true;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Dexterity).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Agility).BaseValue = 1;
		this.GetSkill ((int)SkillName.Wolfs_Howl).Known = true;
		this.GetSkill ((int)SkillName.Wolfs_Howl).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Get_Your_Prey).Known = true;
		this.GetSkill ((int)SkillName.Get_Your_Prey).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}

