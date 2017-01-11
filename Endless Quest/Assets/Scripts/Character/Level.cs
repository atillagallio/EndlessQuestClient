using System.Collections.Generic;
using System;
using UnityEngine;

public class Level {
	private int _currentLevel;
	private uint _freeExp;
	private uint _totalExp;
	private uint _expToNextLevel;
	private List<int> _expList;
	private int _freePointsPerLevel;


	public Level () {
		_currentLevel = 1;
		_freeExp = 0;
		_totalExp = 0;
		_freePointsPerLevel = 3;
		_expList = new List<int> ();
		_expList = GenerateExpList (9999, 15, 100);

	}

	private List<int> GenerateExpList(int _numberOfLevels, int _levelConstant, int _firstLevelExp) {
		int level = 0;
		_expList.Add (0);
		_expList.Add (_firstLevelExp);
		int generatedexp = 0;
		for (int i = 2; i < _numberOfLevels; i++) {
			generatedexp += _expList [_expList.Count - 1];
			_levelConstant = (int)(_levelConstant * 1.1);
			level = (int)(_levelConstant * Math.Sqrt (generatedexp));
			_expList.Add (level);
		}

		return _expList;
	}

	public void CheckIfLevelUp(PlayerCharacter _character) {
		while (_freeExp >= _expList [_currentLevel]) 
		{
			_freeExp -= (uint)_expList [_currentLevel];
			LevelUp(_character);	
		}
	}

	public void LevelUp(PlayerCharacter _character) {
		_currentLevel += 1;
		_character.AddFreeAttributePoints (_freePointsPerLevel);
		foreach (Attribute att in _character.PrimaryAttributeList) {
			att.LevelValue += 1;
		}
		_character.GetSecondaryAttManager.SetupSecAttributesModifiers (_character);
	}

	public int TotalExpNeededtoLevel(int level) {
		return _expList [level];
	}

	public int CurrentLevel {
		get{ return _currentLevel;}
		set{_currentLevel = value; }
	}

	public uint FreeExp {
		get{ return _freeExp; }
		set{ _freeExp = value;}
	}

	public uint TotalExp {
		get{ return _totalExp; }
	}

	public void AddExp(uint exp, PlayerCharacter _character) {

		_totalExp += exp;
		_freeExp += exp;

		CheckIfLevelUp (_character);
		
	}
	public uint ExpToNextLevel {
		get{ return _expToNextLevel; }
		set{ _expToNextLevel = value; }
	}
}


