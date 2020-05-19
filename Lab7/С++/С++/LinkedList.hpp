#ifndef LinkedList_hpp
#define LinkedList_hpp

#include <stdio.h>
#include "Node.hpp"

class LinkedList{
    public:
        Node* head;
        int DividedByFive();
        void PrintList();
        void RemoveAfterMax();
};

#endif /* LinkedList_hpp */
