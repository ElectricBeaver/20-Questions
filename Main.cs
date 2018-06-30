
//Created By Brenden Mitchell

#include<iostream> //needed for consule input and output
using namespace std; //standerd namespace

int main() {
	int max = 100; //max value
	int min = 1;   //min value
	char ans;      //stores user answser
	int num = 0;   //flag and store user number
	int guess;	   //computer guess
	int numGuess = 0; //counter for 20

	cout << "Game created by Brenden Mitchell" << endl;
	cout << "think of a number between 1 and 100." << endl; //promt to user
														   //gives them an idea what to be do

	do {

		guess = min + ((max - min) / 2); //logic for the computer
										 //range of values
		cout << "Is the number greater than or equal to " << guess << "?(Y/N)" << endl;
		cin >> ans;
		//if the number is greater or equal to the compputer guess, do this.
		if (ans == 'y' || ans == 'Y') {

			numGuess++; //incres everytime question asked
			cout << "is your number " << guess << "?(Y/N)" << endl;
			cin >> ans;
			if (ans == 'y' || ans == 'Y') {
				num = guess;
				break;
			}
			else {
				min = guess;
			}
		}
		//if not ma value
		else {
			numGuess++; //increase every qustion asked
			max = guess;

		}
		//do until guesses number or 20 asked questions




	} while (num == 0 && numGuess < 20);
	//if 20 asked and number not guessed you win
	if (numGuess == 20 && num == 0)
		cout << "I could not guess your number in 20 questions. You win" << endl;
	//if computer finds number
	else
		cout << "Your number is " << num << ". I win" << endl;

	system("PAUSE");

	return 0;
}

