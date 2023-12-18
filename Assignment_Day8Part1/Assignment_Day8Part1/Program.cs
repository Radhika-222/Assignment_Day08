﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day8Part1
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string constr = "server=DESKTOP-KT3OE9D;database=Day8AssDb;trusted_connection=true;";

        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "select top 5 * from Products order by PName DESC"
                };
                con.Open();
                reader = cmd.ExecuteReader();
                Console.WriteLine("PId \t Product Name \t \t  Product Price \t \t  Mnf Date \t \t  Exp Date");
                while (reader.Read())
                {
                    Console.Write(reader[0] + "\t ");
                    Console.Write(reader[1] + "\t \t \t ");
                    Console.Write(reader[2] + "\t  \t ");
                    Console.Write(reader[3] + "\t  \t ");
                    Console.Write(reader[4]);
                    Console.Write("\n");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}