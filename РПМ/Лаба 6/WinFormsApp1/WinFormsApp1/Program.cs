using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;

namespace TransportNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // ������ ������ ������������ �������
            List<Transport> transports = new List<Transport>();

            // ��������� �������
            transports.Add(new Plain("����� 747", 400, 900, 2015, 10000));
            transports.Add(new Plain("Airbus A320", 180, 850, 2020, 12000));
            transports.Add(new Ship("������", 300, 25, 2000, Port.����� - ���������));
            transports.Add(new Ship("������� ��������", 1500, 30, 2010, Port.��������));

            // ����������� ����� �����������
            Console.WriteLine("������� ����������� ���������� ����:");
            int minCapacity = int.Parse(Console.ReadLine());

            Console.WriteLine("\n������������ �������� � ������������ ������ ��������:\n");

            // ������� ���������� � ������������ ������ ��������� ��������
            foreach (Transport t in transports)
            {
                if (t.Capacity > minCapacity)
                {
                    t.Show();
                }
            }

            Console.ReadKey();
        }
    }
}
