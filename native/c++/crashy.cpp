#include <exception>
#include <iostream>
#include <string>

extern "C" {
    void segfault() {
        char *ptr = 0;
        *ptr += 1;
    }
}

void substrLengthError() {
    try {
        // throws std::length_error
        std::string("1").substr(2);
    } catch (const std::exception &e) {
        std::cout << e.what() << '\n';
        throw;
    }
}

extern "C" {
    void throwException() {
        callFailingMethod();
    }
}
