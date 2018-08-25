// int counter = 0;
// // while (counter < 10){
// //     Console.WriteLine($"Hello World! The counter is {counter}");
// //     counter ++;
// // }

// // the do...while loop executes the code first, and then checks the condition
// do {
//     Console.WriteLine($"Hello World! The counter is {counter}");
//     counter++;
// } while (counter < 10);

// // for loop
// for(int counter = 0; counter < 10; counter++){
//     Console.WriteLine($"Hello World! The counter is {counter}");
// };

// for loop that checks if variable is divisible by 3
int sum = 0;
for(int number = 0; number < 21; number++){
    if (number % 3 == 0){
        sum = sum+number;
        Console.WriteLine($"The sum is {sum}");
    }
}