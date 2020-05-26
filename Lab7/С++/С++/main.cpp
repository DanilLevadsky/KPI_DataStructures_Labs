#include <iostream>
#include "LinkedList.hpp"

using namespace std;

int main(int argc, const char * argv[]) {
    LinkedList ls;
    ls.Push(4);
    ls.Push(6);
    ls.Push(8);
    ls.Push(5);
    ls.Push(7);
    ls.Push(4);
    cout << ls.DividedByFive() << endl;
    cout << ls.Size() << endl;
    ls.PrintList();
    ls.RemoveAfterMax();
    cout << ls.Size() << endl;
    cout << ls[1] << endl;
    ls.PrintList();
}
