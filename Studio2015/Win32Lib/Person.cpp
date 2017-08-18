#include "stdafx.h"
#include "Person.h"


Person::Person() : IPerson()
{
}

Person::Person(std::string name, int age) : IPerson(name,  age)
{
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

void Person::GetInfo(std::string & name, int & age)
{
	name = _name;
	age = _age;
}

void Person::SetInfo(std::string name, int age)
{
	_name = name;
	_age = age;
}
