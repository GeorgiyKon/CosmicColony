#include <iostream>

extern "C" {
    void calculatePhysics(float mass, float velocity) {
        float momentum = mass * velocity;
        std::cout << "Momentum: " << momentum << std::endl;
    }
}
