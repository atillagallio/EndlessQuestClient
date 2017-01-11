public class SecondaryAttribute : Attribute {
	private int _curValue;
	private int _maxValue;
	private int _minValue;

	public SecondaryAttribute() {
		_curValue = BaseValue;
		_maxValue = 0;
		_minValue = 0;
	}

	public void SetValues(int baseValue, int maxValue, int minValue) {

		BaseValue = baseValue;
		_maxValue = maxValue;
		_minValue = minValue;
		_curValue = baseValue;

	}
	public int CurValue {
		get {
			if ( _curValue > _maxValue)
				_curValue = _maxValue;

			if (_curValue < _minValue)
				_curValue = _minValue;

			return _curValue;
		}
		set{ _curValue = value; }
	}
}

public enum SecondaryAttributeName {
	Health,
	Mana,
	Health_Regen,
	Mana_Regen,
	Magic_Resist,
	Hit,
	Dodge,
	Crit_Chance,
	Crit_Multiplier,
	Damage,
	Attack_Speed,
	Armor,
	Movement_Speed
}

