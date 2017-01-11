using System.Collections;
using System;  //enum class

public class None : HeroClass
{
	public None () {
		this.ClassName = "Aprendice";
		this.ClassTitle = "";
		this.WeaponUsed = "";
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Defense).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Vitality).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Agility).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Dexterity).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Intelligence).BaseValue = 1;
		this.GetPrimaryAttribute((int)PrimaryAttributeName.Strength).BaseValue = 1;

		this.GetSkill ((int)SkillName.Melee_Attack).Known = true;
		this.GetSkill ((int)SkillName.Ranged_Attack).Known = true;

	}

}

