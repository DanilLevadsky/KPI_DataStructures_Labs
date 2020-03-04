#include <iostream>
#include <iterator>
#include <vector>
#include "myString.h"
#include "MyText.h"


using namespace std;

int main() {

auto str1 = MyString("qwerty");
auto str2 = MyString("123123");
auto sub = MyString("123");
MyText txt = MyText();
txt.addString(str1);
txt.addString(str2);
txt.addString(str2);
txt.addString(str1);
txt.addString(str2);
txt.addString(str1);
txt.addString(str2);
txt.addString(str1);
txt.addString(str2);
txt.write();
txt.removeString(sub);
txt.write();
cout << txt.averageLength() << endl;
cout << txt.percentOfVowel() << endl;
}
