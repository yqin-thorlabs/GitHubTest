#pragma once

#include <string>

class Person
{
private:
	std::string _name;
	int _age;

public:
	Person(std::string name, int age);
	Person();
	~Person();

	std::string GetName();
	void SetName(std::string name);
	int GetAge();
	void SetAge(int age);
};
