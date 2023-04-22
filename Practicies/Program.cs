// int Max(int arg1, int arg2, int arg3){
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int[] array = {15, 21, 17, 222, 280, 177, 151, 23, 44};

// int max = Max(Max(array[0], array[1],array[2]), 
//               Max(array[3], array[4], array[5]), 
//               Max(array[6], array[7], array[8]));

// Console.WriteLine("Максимальное число равно " + max);


int[] array = {10, 2, 35, 14, 5, 8, 71, 8};
int size = array.Length;
int find = 8;
int i = 0;

while (i < size){
    if (array[i] == find){
        Console.WriteLine(i);
        break;
    }
    i++;
}
