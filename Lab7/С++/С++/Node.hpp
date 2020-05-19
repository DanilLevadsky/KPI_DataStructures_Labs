#pragma once
#ifndef Node_hpp
#define Node_hpp

#include <stdio.h>

class Node{
    public:
        int value;
        Node* ptr;
        Node(int value);
};

#endif /* Node_hpp */
