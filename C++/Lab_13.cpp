#include <iostream>
template<typename T1>
class Box {
public:
    T1 value;
    
    Box(T1 value) {
        this->value = value;
    }

    int GetSize() {
        return sizeof(value);
    }
};

int main(){
    Box<int> body(12);
    std::cout << body.GetSize() << std::endl;
}