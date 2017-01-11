using System;
using System.Collections.Generic;
using UnityEngine;

public class TitleGenerator
{
	private string _twiceFirstClass = "High";
	private string _threeTimesFirstClass = "Master";
	private string _twiceSecondClass = "Great";
	public string _characterTitle;
	private int numberOfClasses;
		

	public TitleGenerator (List<HeroClass> _heroClasses) {
		numberOfClasses = _heroClasses.Count - 1;
		_characterTitle = string.Empty;
		if (GenerateTitle (_heroClasses) != string.Empty) {
			_characterTitle = GenerateTitle (_heroClasses) + " " + GenerateName (_heroClasses);
		} else {
			_characterTitle = GenerateName (_heroClasses);
		}

	}

	public string GenerateName(List<HeroClass> _heroClasses) {

		if (numberOfClasses < 1) {
			//Aprendice
			return _heroClasses[0].ClassName;
		} else {
			if (numberOfClasses == 2) {

				if (_heroClasses [2].IsDerived && _heroClasses [2].DerivedFrom == _heroClasses [1].ClassName) {

					return _heroClasses [2].ClassName;
				}
					
			}
			if (numberOfClasses == 3) {
				for (int cnt = 2; cnt <= 3; cnt++) {
					if (_heroClasses [cnt].IsDerived && _heroClasses[cnt].DerivedFrom == _heroClasses [1].ClassName) {

						return _heroClasses[cnt].ClassName;
					}	
				}
			}

			return _heroClasses[1].ClassName;
		}
	}

	public string GenerateTitle(List<HeroClass> _heroClasses){

		int numberOfClasses = _heroClasses.Count - 1;
		int equalFirstClassNameTimes = 0;
		int equalClassNumber = 0;
		bool secondEqualThirdClassName = false;
		int uniqueClassNumber = 0;

		for (int cnt = 2; cnt <= numberOfClasses; cnt++) {
			if (_heroClasses [cnt].GetType () == _heroClasses [1].GetType ()) {
				equalFirstClassNameTimes++;
				equalClassNumber = cnt;
			} else {
				uniqueClassNumber = cnt;
			}
			
		}
		if (numberOfClasses == 3) {
			if (_heroClasses [2].GetType () == _heroClasses [3].GetType ()) {
				secondEqualThirdClassName = true;
			}

		}

		if (numberOfClasses == 2) {
			if (equalFirstClassNameTimes > 0) {
				return _twiceFirstClass;
			} else {
				if(!_heroClasses[2].IsDerived)
					return _heroClasses[2].ClassTitle;
			}

		}
		if (numberOfClasses == 3) {
			if (equalFirstClassNameTimes > 0) {
				if (equalFirstClassNameTimes == 1) {
					if (_heroClasses [uniqueClassNumber].IsDerived) {
						return _heroClasses [equalClassNumber].ClassTitle;
					} else {
						return _heroClasses [uniqueClassNumber].ClassTitle + " " + _twiceFirstClass;
					}
				} else {
					return _threeTimesFirstClass;
				}
			}else{
				if (secondEqualThirdClassName) {
					if (_heroClasses [2].IsDerived) {
						return _twiceFirstClass;
					} else {
						return _twiceSecondClass + " " + _heroClasses [2].ClassTitle;
					}
				}
			}
			if (_heroClasses [3].IsDerived && _heroClasses [3].DerivedFrom == _heroClasses [2].ClassName) {

				return _heroClasses [3].ClassTitle;

			} else if (_heroClasses [3].IsDerived) {
				if(_heroClasses [2].IsDerived){
					return _heroClasses [3].ClassTitle;
				}
				return _heroClasses [2].ClassTitle;

			}

			return _heroClasses [3].ClassTitle + " " + _heroClasses [2].ClassTitle; 
		}

		return String.Empty;
	}
}
	


