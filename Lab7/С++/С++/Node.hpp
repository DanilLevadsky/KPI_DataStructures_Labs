#pragma once
#ifndef Node_hpp
#define Node_hpp

#include <stdio.h>

class Node{
    public:
        int value;
        Node* next;
        Node(int value, Node* next);
};

#endif /* Node_hpp */
