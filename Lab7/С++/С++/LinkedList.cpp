#include <iostream>
#include "LinkedList.hpp"

int LinkedList::DividedByFive(){
    int counter = 0;
    Node* temp = head;
    while (temp != NULL) {
        if (temp->value % 5 == 0){
            counter++;
        }
        temp = temp->ptr;
    }
    return counter;
}

void LinkedList::RemoveAfterMax(){
    Node* temp = head;
    int maxElement = head->value;
    while (temp != NULL){
        if (temp->value > maxElement){
            maxElement = temp->value;
        }
        temp = temp->ptr;
    }
    temp = head;
    while (temp != NULL){
        if (temp->value == maxElement){
            temp->ptr = NULL;
        }
        temp = temp->ptr;
    }
}

void LinkedList::PrintList(){
    Node* temp = head;
    while (temp != NULL){
        std::cout << temp->value << " -> ";
        temp = temp->ptr;
    }
    std::cout << "null" << std::endl;
}
