// Win32App.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include <string>
#include <iostream>
#include "Person.h"

using namespace std;

string _sHistory;
void SetString(string s)
{
	_sHistory = s;
}

string GetString()
{
	return _sHistory;
}

int main()
{
	_sHistory = "beta-release - 1st commit";
	cout << _sHistory << endl;
	_sHistory = "beta-release - 2nd commit";
	cout << _sHistory << endl;
	_sHistory = "dev - 1st commit";
	cout << _sHistory << endl;
	_sHistory = "dev - 2nd commit";
	cout << _sHistory << endl;
	_sHistory = "dev - 3rd commit";
	cout << _sHistory << endl;
	_sHistory = "feature1 - 1st commit";
	cout << _sHistory << endl;
	_sHistory = "feature1 - 2nd commit";
	cout << _sHistory << endl;
	_sHistory = "feature2 - 1st commit";
	cout << _sHistory << endl;
	_sHistory = "feature2 - 2nd commit";
	cout << _sHistory << endl;
	_sHistory = "beta-release - 3rd commit";
	cout << _sHistory << endl;
	_sHistory = "dev - 4th commit";
	cout << _sHistory << endl;
	_sHistory = "feature1 - 3rd commit";
	cout << _sHistory << endl;
	_sHistory = "dev - 5th commit";
	cout << _sHistory << endl;
	_sHistory = "beta-release - 4th commit";
	cout << _sHistory << endl;

	return 0;
}

