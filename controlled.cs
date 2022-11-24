void PrintArray (string [] array) {
            
   string [] someArr = array;
   for (int i = 0;  i < someArr.Length; i++ ){
     if (someArr[i].Length <= 3){
     Console.WriteLine($"{someArr[i]}");
     }                    
   }
}
            
string[] Array = {"Hello", "world!", "-2", ":-)"};
string [] Array1 = {"Russia", "Denmark", "Kazan"};
string[] Array2 = {"1234", "1567", "2", "someString"};
            
PrintArray(Array);
PrintArray(Array1);
PrintArray(Array2);
