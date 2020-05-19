#include <iostream>
#include "LinkedList.hpp"

int main(int argc, const char * argv[]) {
    LinkedList ls;
    ls.head = new Node(4);
    Node* node2 =  new Node(1);
    ls.head->ptr = node2;
    Node* node3 =  new Node(5);
    node2->ptr = node3;
    Node* node4 =  new Node(8);
    node3->ptr = node4;
    Node* node5 =  new Node(1);
    node4->ptr = node5;
    ls.PrintList();
    ls.RemoveAfterMax();
    ls.PrintList();
    std::cout << ls.DividedByFive() << std::endl;
}
