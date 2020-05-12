#include <iostream>

using namespace std;

void SortByDescending(int*, int);
void PrintArray(int*, int);

int main() {
    int length;
    cout << "Enter length: ";
    cin >> length;
    int* ls = new int[length];
    for (int i = 1; i <= length; i++) {
        ls[i-1] = i * i;
    }
    void (*funcPtr[2]) (int*, int) = { SortByDescending, PrintArray };
    for (int i = 0; i < 2; i++){
        funcPtr[i](ls, length);
    }
    
}

void SortByDescending(int* ls, int length) {

    for (int i = 0; i < length; i++)
    {
        for (int j = i; j < length; j++)
        {
            if (ls[i] < ls[j])
            {
                char temp = ls[i];
                ls[i] = ls[j];
                ls[j] = temp;
            }
        }
    }
}

void PrintArray(int* ls, int length)
{
    for (int i = 0; i < length; i++){
        cout << ls[i] << " ";
    }
    cout << endl;
}
