#include "Node.hpp"

Node::Node(int value, Node* next = NULL){
    this->value = value;
    this->next = next;
}
