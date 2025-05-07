#include <iostream>
#include <iomanip>
#include <limits>

using namespace std;

int main() {
    int A, B;
    
    cin >> A;
    cin >> B;
    
    cout << setprecision(numeric_limits<double>::digits10 + 1) << (double)A / B << endl;
}
