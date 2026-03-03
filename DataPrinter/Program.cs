using System;

using System;

Console.WriteLine("=== 데이터 출력기 ===");

object[] data =
{
      42, 3.14, "Hello", true,
      100, "World", false, 2.718
};

Console.WriteLine("[전체 데이터 출력]");
PrintAll(data);

Console.WriteLine("[타입별 통계]");
PrintStatistics(data);



static void PrintData(object data)
    {
        string typeName = data.GetType().Name;

        if (typeName == "Int32")
        {
            Console.WriteLine($"정수: {data}");
        }
        else if (typeName == "Double")
        {
            Console.WriteLine($"실수: {(double)data:F2}");
        }
        else if (typeName == "String")
        {
            string str = (string)data;
            Console.WriteLine($"문자열: \"{str}\" (길이: {str.Length})");
        }
        else if (typeName == "Boolean")
        {
            bool b = (bool)data;
            string result = b ? "참" : "거짓";
            Console.WriteLine($"논리값: {b} → {result}");
        }
        else
        {
            Console.WriteLine($"알 수 없는 타입: {typeName} - {data}");
        }
    }

    static void PrintAll(object[] data)
    {
        foreach (object item in data)
        {
            PrintData(item);
        }
    }

    static void PrintStatistics(object[] data)
    {
        int intCount = 0;
        int doubleCount = 0;
        int stringCount = 0;
        int boolCount = 0;

        foreach (object item in data)
        {
            string typeName = item.GetType().Name;

            if (typeName == "Int32")
                intCount++;
            else if (typeName == "Double")
                doubleCount++;
            else if (typeName == "String")
                stringCount++;
            else if (typeName == "Boolean")
                boolCount++;
        }

        Console.WriteLine($"정수: {intCount}개");
        Console.WriteLine($"실수: {doubleCount}개");
        Console.WriteLine($"문자열: {stringCount}개");
        Console.WriteLine($"논리값: {boolCount}개");
    }

