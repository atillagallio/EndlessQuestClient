public class BaseStat{
	private int _baseValue;
	private int _levelValue;
	private int _bonusValue;


	public BaseStat(){
		_baseValue = 0;
		_levelValue = 1;
		_bonusValue = 0;
		
	}

	public int BaseValue {
		get{ return _baseValue; }
		set{ _baseValue = value; }
	}

	public int LevelValue {
		get{ return _levelValue; }
		set{ _levelValue = value; }
	}

	public int BonusValue {
		get{ return _bonusValue; }
		set{ _bonusValue = value; }
	}
		
	public int AdjustedBaseValue {
		get{ return _baseValue*_levelValue + _bonusValue;}
	}
}

