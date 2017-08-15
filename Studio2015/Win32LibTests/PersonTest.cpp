#include "gtest/gtest.h"
#include "gmock/gmock.h"
#include "Person.h"

namespace // not required
{
	class PersonMock : public Person {
	public:

		//MOCK_CONST_METHOD1(GetPersonalInfoFromDb, std::string(const std::string&));
	};

	TEST(PersonTest, GetAgeTest)
	{
		Person *p = new Person();
		p->SetAge(10);
		EXPECT_EQ(10, p->GetAge());
		p->SetAge(20);
		EXPECT_EQ(20, p->GetAge());
	}

	TEST(PersonTest, SetAgeTest)
	{
		PersonMock mock;
		//EXPECT_CALL(mock, GetPersonalInfoFromDb("Db info")).WillOnce(Return(std::string(html)));
		
		Person *p = new Person();
		p->SetAge(10);
		EXPECT_EQ(10, p->GetAge());
		p->SetAge(20);
		EXPECT_EQ(20, p->GetAge()); // ASSERT_TRUE; ASSERT_THAT; EXPECT_TRUE(); ASSERT_EQ; 
	}
}