#include "gtest/gtest.h"
#include "gmock/gmock.h"
#include "Person.h"

namespace // not required
{
	//EXPECT_NE
	//EXPECT_GE
	//EXPECT_LE
	//EXPECT_NE
	//EXPECT_LT
	//EXPECT_FLOAT_EQ
	//EXPECT_DOUBLE_EQ
	//ASSERT_FLOAT_EQ
	//EXPECT_NEAR
	//EXPECT_STREQ
	//EXPECT_STRNE
	TEST(PersonTest, GetAgeTest)
	{
		Person *p = new Person();
		p->SetAge(10);
		EXPECT_EQ(10, p->GetAge());
		p->SetAge(20);
		EXPECT_EQ(20, p->GetAge()); // EXPECT_TRUE(); ASSERT_EQ; 
	}

	TEST(PersonTest, SetAgeTest)
	{
		Person *p = new Person();
		p->SetAge(10);
		EXPECT_EQ(10, p->GetAge());
		p->SetAge(20);
		EXPECT_EQ(20, p->GetAge());
	}

	TEST(PersonTest, GetInfoTest)
	{
		std::string name;
		int age;

		Person *p = new Person();
		p->SetInfo("David", 20);
		p->GetInfo(name, age);
		EXPECT_EQ("David", name);
		EXPECT_EQ(20, age);

		p->SetInfo("Catherine", 17);
		p->GetInfo(name, age);
		EXPECT_EQ("Catherine", name);
		EXPECT_EQ(17, age);
	}

	TEST(PersonTest, SetInfoTest)
	{
		std::string name;
		int age;

		Person *p = new Person();
		p->SetInfo("David", 20);
		p->GetInfo(name, age);
		EXPECT_EQ("David", name);
		EXPECT_EQ(20, age);

		p->SetInfo("Catherine", 17);
		p->GetInfo(name, age);
		EXPECT_EQ("Catherine", name);
		EXPECT_EQ(17, age);
	}
}
