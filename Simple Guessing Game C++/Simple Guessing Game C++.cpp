#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

int generatedNumber;

void Menu() {
	cout << "Simple guessing game" << endl;
	cout << "1. Play" << endl;
	cout << "2. How to play" << endl;
	cout << "3. Exit" << endl;
}

void GenerateNumber(int range, int offset) {
	srand((unsigned)time(0));
	generatedNumber = (rand() % range) + offset;
}

int main() {
	int choice, guess = 0;
	do {
		Menu();
		cin >> choice;
		switch (choice) {
		case 1:
			int min, max;
			cout << "Choose 2 numbers between which the game will generated the number you have to guess:" << endl;
			cin >> min >> max;
			GenerateNumber(max, min);
			while (guess != generatedNumber)
			{
				cout << "Guess the number: ";
				cin >> guess;
				if (guess < generatedNumber)
					cout << "The number is bigger \n";
				else if (guess > generatedNumber)
					cout << "The number is smaller \n";
			}
			cout << "You guessed the number! (" << generatedNumber << ") \n\n";
			break;


		case 2:
			cout << "A number will be randomly generated and the player will have to guess it" << endl;
			cout << "The game will tell you if the number is bigger or smaller than the number you input \n" << endl;
			break;

		case 3:
			cout << "Goodbye!" << endl;
			break;
		}
	} while (choice != 3);


	return 0;
}