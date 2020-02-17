//
//  main.cpp
//  C++ version of first Laboratory work
//
//  Created by Danil Levadsky on 16.02.2020.
//  Copyright © 2020 Danil Levadsky. All rights reserved.
//

#include <iostream>
#include <string>

using namespace std;

string DecimalToBinary(int);
string ExtendBits(string, int);
int Increment(int);
void Increment(int, int&);
bool MoreThan(int, int);
void MoreThan(int, int, bool&);

int main(int argc, const char * argv[]) {
}

string DecimalToBinary(int number)
{
    if (number < 0)
        number += 256;
    string result = "";
    while(number > 0){
        result = string(1, (char) (number % 2 + 48)) + result;
        number /= 2;
    }
    return result;
}   

int Increment(int number)
{
    int result = number;
    int index = DecimalToBinary(number).rfind('0');
    for (int i = 0; i < DecimalToBinary(number).length()-index; i = -~i)
    {
        result ^= (1<<i);
    }
    return result;
}

void Increment(int number, int& result)
{
    result = number;
    int index = DecimalToBinary(number).rfind('0');
    for (int i = 0; i < DecimalToBinary(number).length()-index; i = -~i)
    {
        result ^= (1<<i);
    }
}

string ExtendBits(string binary, int length)
{
    
    if (length > binary.size())
        binary.insert(0, length-binary.size(), '0');
    return binary;
}

bool MoreThan(int number1, int number2)
{
    string binary1 = ExtendBits(DecimalToBinary(number1), 16);
    string binary2 = ExtendBits(DecimalToBinary(number2), 16);
    for (int i = 0; i < 16; Increment(i, i))
    {
        if ((stoi(to_string((binary1[i]))) & 1))
        {
            if ((stoi(to_string((binary1[i]))) ^ stoi(to_string((binary2[i])))))
            {
             if (stoi(to_string(binary2[i])) != 1)
             {
                 return true;
             }
            }
        }
        if (((stoi(to_string(binary1[i]))) & 1) != 1)
        {
            if (stoi(to_string(binary2[i])) & 1)
            {
                return false;
            }
        }
    }
    return false;
}

void MoreThan(int number1, int number2, bool& result)
{
    string binary1 = ExtendBits(DecimalToBinary(number1), 16);
    string binary2 = ExtendBits(DecimalToBinary(number2), 16);
    for (int i = 0; i < 16; Increment(i, i))
    {
        if ((stoi(to_string((binary1[i]))) & 1))
        {
            if ((stoi(to_string((binary1[i]))) ^ stoi(to_string((binary2[i])))))
            {
             if (stoi(to_string(binary2[i])) != 1)
             {
                 result = true;
                 return;
             }
            }
        }
        if (((stoi(to_string(binary1[i]))) & 1) != 1)
        {
            if (stoi(to_string(binary2[i])) & 1)
            {
                result = false;
                return;
            }
        }
    }
    result = false;
}

