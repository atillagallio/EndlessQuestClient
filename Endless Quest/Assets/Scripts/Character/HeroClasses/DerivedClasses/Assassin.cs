using System.Collections.Generic;
using System;  //enum class

public class Assassin : HeroClass
{
	public Assassin (){
		this.DerivedFrom = "Thief";
		this.ClassName = "Assassin";
		this.ClassTitle = "Blood";
		this.WeaponUsed = "Blade";
		this.IsDerived = true;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Strength).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Agility).BaseValue = 1;
		this.GetSkill ((int)SkillName.Killing_Blow).Known = true;
		this.GetSkill ((int)SkillName.Killing_Blow).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Bloody_Frenzy).Known = true;
		this.GetSkill ((int)SkillName.Bloody_Frenzy).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}

