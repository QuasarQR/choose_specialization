string[] array = new string[8] {"hi", "hello", "how are you?", "10", "GeekBrains", "me", "yes", "chair"};
string[] result = new string[array.Length];
int outputIndex = 0;

Console.WriteLine("Элементы исходного массива: ");

foreach (string el in array){
   Console.Write("[" + el + "]" + " ");
}

Console.WriteLine();

for (int i = 0; i < array.Length; i ++){
   if (array[i].Length <= 3){
      result[outputIndex] = array[i];
      outputIndex++;
   }
}

Array.Resize(ref result, outputIndex);

Console.WriteLine("Новый массив, в котором длина строк меньше, либо равна 3 символам: ");

foreach (string el in result){
   Console.Write("[" + el + "]" + " ");
}