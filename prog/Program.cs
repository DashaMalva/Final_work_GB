Console.Write("Enter the amount of words you'd like to enter next (max 10): ");
int size = int.Parse(Console.ReadLine());
while (size <=0 || size > 10) {
    Console.Write("The amount has to be greater than 0 and less than 10! Enter again: ");
    size = int.Parse(Console.ReadLine());
} 
string[] array = new string[size];
for (int i = 0; i < size; i++) {
    array[i] = Console.ReadLine();
}


int FindAmountOfElements(string[] array, int maxLength) {
    int result = 0;
    for (int i = 0; i < size; i++) {
        if (array[i].Length <= maxLength) {
            result++;
        }
    }
    return result;
}


string[] newArray = new string[FindAmountOfElements(array, 3)];
int j = 0;
for (int i = 0; i < size; i++) {
    if (array[i].Length <= 3) {
        newArray[j] = array[i];
        j++;
    }
}

Console.WriteLine();
Console.WriteLine("Words of length <= 3: ");
if (newArray.Length > 0) Console.WriteLine(string.Join(", ", newArray));
else Console.WriteLine("no words found");
