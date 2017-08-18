#include "stdafx.h"
#include "CppUnitTest.h"

#include "MyCalculator.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace Win32App_MSTest
{
	TEST_CLASS(CalculatorTest)
	{
	public:

		TEST_METHOD(AddTest)
		{
			MyCalculator calc;
			//p->SetName("David");
			//Assert::AreEqual("David", p->GetName().c_str());
			//p->SetName("Catherine");
			//Assert::AreEqual("Catherine", p->GetName().c_str());
		}

		TEST_METHOD(MulTest)
		{
		}
	};
}