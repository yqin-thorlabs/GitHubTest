#pragma once

#include "Win32Lib.h"
#include "Person.h"
#include <string>

//class LIBRARY_API Employee final : public Person // no inherance allowed
class LIBRARY_API Employee : public Person
{
private:
	double _baseSalary;
	double _bonus;
	int _yearsEmployed;

public:
	Employee(std::string name, int age, int yearsEmployed, double _baseSalary, double _bonus);
	Employee();
	~Employee();

	// const before the function - the return value cannot be changed
	// const after the function - the function cannot change any data member(s) in the class
	// const inside function parameter(s) - the parameter cannot be changed inside function
	double Earnings() const;

	virtual void DoSomething();
};

