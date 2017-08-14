#include "stdafx.h"

#include "gtest/gtest.h"
#include "Person.h"

TEST(PersonTest, GetAgeTest)
{
	Person *p = new Person();
	p->SetAge(10);
	EXPECT_EQ(10, p->GetAge());
	p->SetAge(20);
	EXPECT_EQ(20, p->GetAge());
}