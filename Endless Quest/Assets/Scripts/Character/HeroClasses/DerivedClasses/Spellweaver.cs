using System.Collections.Generic;
using System;  //enum class

public class Spellweaver : HeroClass
{
	public Spellweaver (){
		this.DerivedFrom = "Mage";
		this.ClassName = "Spellweaver";
		this.ClassTitle = "Witch";
		this.WeaponUsed = "Book";
		this.IsDerived = true;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Intelligence).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Dexterity).BaseValue = 1;
		this.GetSkill ((int)SkillName.Arcane_Burn).Known = true;
		this.GetSkill ((int)SkillName.Arcane_Burn).AddCooldown (new List<int>(new int[] {500,350,150}));
		this.GetSkill ((int)SkillName.Arctic_Explosion).Known = true;
		this.GetSkill ((int)SkillName.Arctic_Explosion).AddCooldown (new List<int>(new int[] {10,10,10}));

	}

}

