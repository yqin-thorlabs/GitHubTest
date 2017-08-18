#include "stdafx.h"
#include "Employee.h"


Employee::Employee(std::string name, int age, int yearsEmployed, double baseSalary, double bonus) : Person(name, age)
{
	_yearsEmployed = yearsEmployed;
	_baseSalary = baseSalary;
	_bonus = bonus;
}

Employee::Employee() : Person()
{
}


Employee::~Employee()
{
}

double Employee::Earnings() const
{
	return (_baseSalary * (1 + 0.01 * _yearsEmployed) + _bonus);
}

void Employee::DoSomething()
{
}
