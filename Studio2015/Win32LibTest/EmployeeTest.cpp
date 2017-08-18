#include "gtest/gtest.h"
#include "gmock/gmock.h"
#include "Employee.h"

namespace // not required
{
	TEST(EmployeeTest, GetAgeTest)
	{
		Employee *pEmployee = new Employee();
		pEmployee->SetAge(10);
		EXPECT_EQ(10, pEmployee->GetAge());
		pEmployee->SetAge(20);
		EXPECT_TRUE(20 == pEmployee->GetAge()); //ASSERT_EQ; 
	}

	TEST(PersonTest, SetAgeTest)
	{
		Employee *pEmployee = new Employee();
		pEmployee->SetAge(10);
		EXPECT_EQ(10, pEmployee->GetAge());
		pEmployee->SetAge(20);
		EXPECT_TRUE(20 == pEmployee->GetAge()); //ASSERT_EQ; 
	}

	TEST(PersonTest, EarningsTest)
	{
		std::string name;
		int age;

		Employee *pEmployee = new Employee("David", 20, 2, 1000.0, 100.0);
		pEmployee->Earnings();
		pEmployee->GetInfo(name, age);
		EXPECT_EQ("David", name);
		EXPECT_EQ(20, age);

		pEmployee->SetInfo("Catherine", 17);
		pEmployee->GetInfo(name, age);
		EXPECT_EQ("Catherine", name);
		EXPECT_EQ(17, age);
	}

	TEST(PersonTest, SetInfoTest)
	{
		std::string name;
		int age;

		Employee *pEmployee = new Employee();
		pEmployee->SetInfo("David", 20);
		pEmployee->GetInfo(name, age);
		EXPECT_EQ("David", name);
		EXPECT_EQ(20, age);

		pEmployee->SetInfo("Catherine", 17);
		pEmployee->GetInfo(name, age);
		EXPECT_EQ("Catherine", name);
		EXPECT_EQ(17, age);
	}
}
