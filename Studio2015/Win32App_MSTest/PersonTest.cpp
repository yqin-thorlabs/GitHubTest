#include "stdafx.h"
#include "CppUnitTest.h"

#include "Person.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace Win32App_MSTest
{		
	TEST_CLASS(PersonTest)
	{
	public:
		
		TEST_METHOD(GetNameTest)
		{
			Person *p = new Person();
			p->SetName("David");
			Assert::AreEqual("David", p->GetName().c_str());
			p->SetName("Catherine");
			Assert::AreEqual("Catherine", p->GetName().c_str());
		}

		TEST_METHOD(SetNameTest)
		{
			Person *p = new Person();
			p->SetName("David");
			Assert::AreEqual("David", p->GetName().c_str());
			p->SetName("Catherine");
			Assert::AreEqual("Catherine", p->GetName().c_str());
		}

		TEST_METHOD(GetAgeTest)
		{
			Person *p = new Person();
			p->SetAge(10);
			Assert::AreEqual(10, p->GetAge());
			p->SetAge(20);
			Assert::AreEqual(20, p->GetAge());
		}

		TEST_METHOD(SetAgeTest)
		{
			Person *p = new Person();
			p->SetAge(10);
			Assert::AreEqual(10, p->GetAge());
			p->SetAge(20);
			Assert::AreEqual(20, p->GetAge());
		}
	};
}