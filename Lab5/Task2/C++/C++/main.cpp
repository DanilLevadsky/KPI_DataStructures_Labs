#include <iostream>
#include "MyString.hpp"
#include "LowerCase.hpp"
#include "CapitalLetter.hpp"

using namespace std;

int main(int argc, const char * argv[]) {
    auto st1 = new MyString("qweRtY");
    cout << st1->GetValue() << endl;
    st1->Insert('o', 1);
    cout<< st1->GetValue() << endl;
    auto st2 = new CapitalLetter("qwErTy");
    cout << st2->GetValue() << endl;
    st2->Insert('i', 1);
    cout << st2->GetValue() << endl;
    auto st3 = new LowerCase("qwErTy");
    cout << st3->GetValue() << endl;
    st3->Insert('B', 1);
    cout << st3->GetValue() << endl;
} 
 
