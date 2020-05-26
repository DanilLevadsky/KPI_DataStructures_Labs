#include <iostream>
#include "LinkedList.hpp"

LinkedList::LinkedList(){
    head = NULL;
    _size = 0;
}

void LinkedList::Push(int value){
    if (head == NULL){
        head = new Node(value, NULL);
        current = head;
        _size++;
        return;
    }
    auto newNode = new Node(value, NULL);
    current->next = newNode;
    current = newNode;
    _size++;
}


int LinkedList::DividedByFive(){
    int counter = 0;
    current = head;
    while (current != NULL) {
        if (current->value % 5 == 0){
            counter++;
        }
        current = current->next;
    }
    return counter;
}

int& LinkedList::operator[](const int index){
    int counter = 0;
    int result = 0;
    current = head;
    while (current != NULL){
        if (counter == index){
            result = current->value;
            break;
        }
        current = current->next;
        counter++;
    }
    return result = -1;
}


int LinkedList::Size() {
    return this->_size;
    
}

void LinkedList::RemoveAfterMax(){
    current = head;
    int maxElement = head->value;
    while (current != NULL){
        if (current->value > maxElement){
            maxElement = current->value;
        }
        current = current->next;
    }
    current = head;
    _size = 0;
    while (current != NULL){
        if (current->value == maxElement){
            current->next = NULL;
        }
        current = current->next;
        _size++;
    }
}

void LinkedList::PrintList(){
    current = head;
    while (current != NULL){
        std::cout << current->value << " -> ";
        current = current->next;
    }
    std::cout << "null" << std::endl;
}
