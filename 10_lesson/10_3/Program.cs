// Определить номер четверти плоскости, в которой находится 
//точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// 1 x > 0; y > 0;
// 2 x > 0; y < 0;
// 3 x < 0; y < 0;
// 4 x < 0; y > 0;

string CheckingQuarter (int x, int y)
{
    string flag = " ";
    if (x != 0 || y != 0)
    {
        if (x > 0 && y > 0)
            flag = "1 quarter";
            else if (x > 0 && y < 0)
            flag = "2 quarter";
            else if (x < 0 && y < 0)
            flag = "3 quarter";
            else if (x < 0 && y > 0)
            flag = "4 quarter";
    }
    return flag;
}

Console.WriteLine ("Введите x: ");
int x = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите y: ");
int y = int.Parse (Console.ReadLine());

Console.WriteLine(CheckingQuarter (x, y));


