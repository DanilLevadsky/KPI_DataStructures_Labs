#ifndef LinkedList_hpp
#define LinkedList_hpp

#include <stdio.h>
#include "Node.hpp"

class LinkedList{
    public:
        int Size();
        void Push(int value);
        int& operator[](const int index);
        int DividedByFive();
        void PrintList();
        void RemoveAfterMax();
        LinkedList();
    
    private:
        Node* head;
        Node* current;
        int _size;
};

#endif /* LinkedList_hpp */
