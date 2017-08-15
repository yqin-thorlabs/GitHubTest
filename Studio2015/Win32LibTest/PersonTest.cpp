//#include "stdafx.h"
//
#include "gtest/gtest.h"
#include "gmock/gmock.h"
#include "Person.h"

namespace // not required
{
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
}
