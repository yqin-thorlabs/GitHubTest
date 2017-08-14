#include "stdafx.h"
#include "Person.h"


Person::Person()
{
}

Person::Person(std::string name, int age)
{
	_name = name;
	_age = age;
}

Person::~Person()
{
}

std::string Person::GetName()
{
	return _name;
}

void Person::SetName(std::string name)
{
	_name = name;
}

int Person::GetAge()
{
	return _age;
}

void Person::SetAge(int age)
{
	_age = age;
}
