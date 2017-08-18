#pragma once

#include "Win32Lib.h"

class LIBRARY_API MyCalculator
{
public:
	MyCalculator();
	~MyCalculator();

	int Add(int num1, int num2);
	int Mul(int num1, int num2);
};

