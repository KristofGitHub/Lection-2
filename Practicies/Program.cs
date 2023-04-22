int a1 = 15;
int b1 = 21;
int c1 = 17;

int a2 = 22;
int b2 = 28;
int c2 = 177;

int a3 = 151;
int b3 = 23;
int c3 = 44;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine("Максимальное число равно " + max);
