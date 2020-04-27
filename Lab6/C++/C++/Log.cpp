#include "Log.hpp"

#include <cstring>
#include <ctime>

void Log::LogTrace(const char* exception, std::string fileName) {
    time_t timer = time(0);
    tm* now = std::localtime(&timer);
    std::ofstream file;
    file.open(fileName, std::ios_base::app);
    file << (now->tm_year + 1900) << '-' << (now->tm_mon + 1) << '-' << now->tm_mday << ' ';
    file << (now->tm_hour) << ':' << now->tm_min << ':' << now->tm_sec << "\t";
    file << exception << std::endl << std::endl;
}
