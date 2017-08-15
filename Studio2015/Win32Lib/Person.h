#pragma once

#ifdef LIBRARY_EXPORTS  
#define LIBRARY_API __declspec(dllexport)   
#else  
#define LIBRARY_API __declspec(dllimport)   
#endif  

#include <string>

class LIBRARY_API Person
{
private:
	std::string _name;
	int _age;

public:
	Person(std::string name, int age);
	Person();
	~Person();

	std::string GetName();
	void SetName(std::string name);
	int GetAge();
	void SetAge(int age);
};
