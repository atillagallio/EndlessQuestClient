using UnityEngine;

public class SecondaryAttManager
{
	private int _vit;
	private int _agi;
	private int _int;
	private int _str;
	private int _dex;
	private int _def;

	public SecondaryAttManager (BaseCharacter character)
	{
		SetupSecAttributes (character);
		SetupSecAttributesModifiers (character);

	}

	private void GetAttributeValuesFromCharacter(BaseCharacter character) {

		_vit = character.PrimaryAttributeList [(int)PrimaryAttributeName.Vitality].AdjustedBaseValue;
		_agi = character.PrimaryAttributeList [(int)PrimaryAttributeName.Agility].AdjustedBaseValue;
		_int = character.PrimaryAttributeList [(int)PrimaryAttributeName.Intelligence].AdjustedBaseValue;
		_str = character.PrimaryAttributeList [(int)PrimaryAttributeName.Strength].AdjustedBaseValue;
		_dex = character.PrimaryAttributeList [(int)PrimaryAttributeName.Dexterity].AdjustedBaseValue;
		_def = character.PrimaryAttributeList [(int)PrimaryAttributeName.Defense].AdjustedBaseValue;

	}

	private void SetupSecAttributes(BaseCharacter character){
		for (int cnt = 0; cnt < character.SecondaryAttributeList.Length; cnt++) {
			character.SecondaryAttributeList[cnt] = new SecondaryAttribute();
		}
	}

	public void SetupSecAttributesModifiers(BaseCharacter character) {

		GetAttributeValuesFromCharacter (character);

		SetupHealth (character);
		SetupMana (character);
		SetupResist (character);
		SetupOffense (character);
		SetupMovespeed (character);

	}

	private void SetupHealth (BaseCharacter character){
		int health_f = (10 * _vit + 2 * _def);
		int health_regen_f = (int)(_vit/5);
		character.SecondaryAttributeList [(int)SecondaryAttributeName.Health].SetValues (health_f, health_f, 0); //health (10 * Vit)
		character.SecondaryAttributeList [(int)SecondaryAttributeName.Health_Regen].SetValues(health_regen_f, health_f, 1); 

	}

	private void SetupMana (BaseCharacter character){
		int mana_f = 5 * _int;
		int mana_regen_f =  (int)(_int /5);
		character.SecondaryAttributeList [(int)SecondaryAttributeName.Mana].SetValues (mana_f, mana_f, 0); //Mana (5 * Int)
		character.SecondaryAttributeList [(int)SecondaryAttributeName.Mana_Regen].SetValues(mana_regen_f, mana_f, 1); //mana_regen (1/5 * Int)

	}

	private void SetupResist (BaseCharacter character){
		int armor_f = (int)(_def * 100/ (200 + _def));
		int mr_f = (int)(_int * 100 / (200 + _int));
		int dodge_f = (int)(_agi * 100/ (500 + _agi));
		character.SecondaryAttributeList [(int)SecondaryAttributeName.Armor].SetValues (armor_f, 100, 0);
		character.SecondaryAttributeList [(int)SecondaryAttributeName.Magic_Resist].SetValues (mr_f, 100, 0);
		character.SecondaryAttributeList [(int)SecondaryAttributeName.Dodge].SetValues (dodge_f, 100, 0);
	}

	private void SetupOffense (BaseCharacter character){

		int damage_f = (int)(_str * 1.5 + _dex);
		int hit_f = (int)(_dex * 1.5);
		int crit_chance_f = (int)(_dex *100 / (300 + _dex));
		int crit_mult_f = (int)((200 + ((_dex/2 * _agi/2) / (20)))/100);
		double as_helper = _agi* 62.5/(100 + _agi);
		as_helper = as_helper * (1 + _agi / 100);
		int as_f = (int)(62.5 + as_helper);
		character.SecondaryAttributeList [(int)SecondaryAttributeName.Damage].SetValues (damage_f, damage_f, 1);
		character.SecondaryAttributeList [(int)SecondaryAttributeName.Hit].SetValues(hit_f, hit_f, 0);
		character.SecondaryAttributeList [(int)SecondaryAttributeName.Crit_Chance].SetValues (crit_chance_f, 100, 0);
		character.SecondaryAttributeList [(int)SecondaryAttributeName.Crit_Multiplier].SetValues (crit_mult_f, 10, 0);
		character.SecondaryAttributeList [(int)SecondaryAttributeName.Attack_Speed].SetValues (as_f, 250, 62);

	}

	private void SetupMovespeed (BaseCharacter character)
	{
		int ms_f = 1;

		character.SecondaryAttributeList [(int)SecondaryAttributeName.Movement_Speed].SetValues (ms_f, 10, 1);
	}



}


