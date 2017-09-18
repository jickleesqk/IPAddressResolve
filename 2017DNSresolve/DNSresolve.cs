using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace _2017DNSresolve
{
    class  DNSresolve
    {
        public static void PrintHostInfo(string host)
        {
            try
            {
                IPHostEntry hostinfo;
                hostinfo = Dns.GetHostEntry(host); //phan giai DNS duoc cho boi host hoac dia chi
                Console.WriteLine("\tInput: " + hostinfo.HostName ); //hien thi host duoc uu tien dau tien

                //hien thi danh sach cac dia chi IP cua host
                Console.Write("\tIPAddress: \n\t\t");
                foreach(IPAddress ipa in hostinfo.AddressList)
                {
                    Console.Write(ipa.ToString() + "\n\t\t");
                }
                Console.WriteLine();

                //hien thi danh sach ten alias cua host
                Console.Write("\tAlias: \n");
                foreach (string alias in hostinfo.Aliases)
                {
                    Console.Write(alias + "\n\t\t");
                }
                Console.WriteLine("\n");
            } catch(Exception)
            {
                Console.WriteLine("\tUnable to resolve host: " + host + "\n");
            }
        }
        static void Main(string[] args)
        {
            //lay va in ra thong tin host cua may local 
            try
            {
                Console.WriteLine("Local Host: ");
                string localhostname = Dns.GetHostName();
                Console.WriteLine("\tHost Name: " + localhostname);

                PrintHostInfo(localhostname);
            } catch(Exception)
            {
                Console.WriteLine("Unable to resolve Local Host\n");
            }

            //nhan va in ra thong tin host muon tim tren cmd
            foreach(string arg in args)
            {
                Console.WriteLine(arg + ":");
                PrintHostInfo(arg);
            }
            Console.ReadKey();
        }
    }
}
