#pragma once

#include "Win32Lib.h"
#include "IPerson.h"
#include <string>

class LIBRARY_API Person : public IPerson
{
public:
	Person(std::string name, int age);
	Person();
	~Person();

	std::string GetName();
	void SetName(std::string name);
	int GetAge();
	void SetAge(int age);
	void GetInfo(std::string& name, int& age);
	void SetInfo(std::string name, int age);
};
