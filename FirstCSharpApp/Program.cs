//Main C# Application

Console.Clear();
Console.WriteLine("Welcome to my first C# application!");
strLine("-", 30);
Console.WriteLine("โปรแกรมแนะนำตัวเอง");
Console.WriteLine("โปรดกรอกชื่อของคุณ: ");
string name = Console.ReadLine();
Console.WriteLine("สวัสดี, " + name + "!");
strLine("-", 30);
Console.WriteLine("ขอบคุณที่ใช้โปรแกรมของฉัน!");
//ทดสอบสร้าง Function
void strLine(string strInput, int n)
{
    string strOutput = "";
    for (int i = 0; i < n; i++)
    {
        strOutput += strInput;
    }
    Console.WriteLine(strOutput+"\n");
}



