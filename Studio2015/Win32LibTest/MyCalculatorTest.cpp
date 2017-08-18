#include "gtest/gtest.h"
#include "gmock/gmock.h"
#include "MyCalculator.h"

namespace // not required
{
	TEST(MyCalculatorTest, AddTest)
	{
		MyCalculator calc;
		int num1 = 1;
		int num2 = 2;
		int sum = calc.Add(num1, num2);
		EXPECT_EQ(10, sum);
	}

	TEST(MyCalculatorTest, MulTest)
	{
		MyCalculator calc;
		int num1 = 1;
		int num2 = 2;
		int mul = calc.Mul(num1, num2);
		ASSERT_EQ(20, mul);
	}

	class MockEmployee : public MyCalculator
	{
		MOCK_METHOD1(SetName, void(std::string name));
		MOCK_METHOD2(SetInfo, void(std::string name, int age));
		MOCK_METHOD0(GetName, std::string());
		MOCK_METHOD0(GetAge, int());
		MOCK_CONST_METHOD0(Earnings, void());
	};
}
