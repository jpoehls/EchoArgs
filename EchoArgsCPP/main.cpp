#include <iostream>
#include <Windows.h>

using namespace std;

int main(int argc, char* argv[]) {
	cout << "# argv" << endl;
	for(int i = 0; i < argc; i++)
		cout << "[" << i << "]: " << argv[i] << endl;

	cout << endl;

	LPCWSTR szCmdLine = GetCommandLineW();
	cout << "# GetCommandLineW()" << endl;
	printf("%ls", szCmdLine);
	cout << endl;

	cout <<endl;
	cout << "# CommandLineToArgvW()" << endl;

	LPWSTR *argv2 = CommandLineToArgvW(szCmdLine, &argc);
	for (int i = 0; i < argc; i++) {
		cout << "[" << i << "]: ";
		printf("%ls", argv2[i]);
		cout << endl;
	}

	return 0;
} 