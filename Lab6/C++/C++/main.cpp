#include <iostream>
#include "Log.hpp"
#include "Expression.hpp"
#include <cstring>


int main(int argc, const char * argv[]) {
    const std::string fileName = "/Users/danillevadsky/RiderProjects/KPILabs/Lab6/C++/C++/exception.log";
    Log log = Log();
    auto exp = Expression(5, 1, -7);
    try {
        double result = exp.Calculate();
        std::cout << "Result: " << result << std::endl;
    } catch (const char* e) {
        log.LogTrace(e, fileName); 
    }
}
