#ifndef Log_hpp
#define Log_hpp

#include <stdio.h>
#include <cstring>
#include <fstream>

class Log {
    public:
        void LogTrace(const char*, std::string);
};

#endif
