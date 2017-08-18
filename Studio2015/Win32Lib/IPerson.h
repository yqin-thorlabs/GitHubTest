#pragma once

#include "Win32Lib.h"
#include <string>

class LIBRARY_API IPerson
{
protected:
	std::string _name;
	int _age;

public:
	IPerson(std::string name, int age);
	IPerson();
	virtual ~IPerson();

	virtual std::string GetName() = 0;
	virtual void SetName(std::string name) = 0;
	virtual int GetAge() = 0;
	virtual void SetAge(int age) = 0;
	virtual void GetInfo(std::string& name, int& age) = 0;
	virtual void SetInfo(std::string name, int age) = 0;
};

