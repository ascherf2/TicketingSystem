﻿using System;
using System.IO;

namespace TicketingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "tickets.csv";
            string choice;
            do
            {
                // ask user a question
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");

                // input response
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Read data from file
                    if (File.Exists(file))
                    {


                        // read data from file
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            // convert string to array

                            string[] arr = line.Split('|');
                            // display array data

                            Console.WriteLine("Ticket ID: {0}, Summary: {1}, Status: {2}, Priority: {3}, Submitter: {4}, Assigned: {5}, Watching: {6}", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);


                            sr.Close();
                        }
                    }


                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                    
                    else if (choice == "2")
                    {
                        // create file from data
                        StreamWriter sw = new StreamWriter(file);
                        for (int i = 0; i < 7; i++)
                        {
                            // ask a question
                            Console.WriteLine("Would you like to enter a ticket? (Y/N)?");

                            // input the response
                            string resp = Console.ReadLine().ToUpper();

                            // if the response is anything other than "Y", stop asking
                            if (resp != "Y") { break; }

                            // prompt for Ticket ID
                            Console.WriteLine("Enter ticket ID");

                            // save the Ticket ID
                            string ticketid = Console.ReadLine();

                            // prompt for summary
                            Console.WriteLine("Enter a summary: ");

                            // save the summary
                            string summary = Console.ReadLine().ToUpper();

                            // prompt for status
                            Console.WriteLine("Enter the ticket status: ");

                            // save the status
                            string status = Console.ReadLine().ToUpper();

                            // prompt for priority
                            Console.WriteLine("Enter the priority level of the ticket: ");

                            // save the priority
                            string priority = Console.ReadLine().ToUpper();

                            // prompt for submitter
                            Console.WriteLine("Enter the submitter for the ticket: ");

                            // save the submitter
                            string submitter = Console.ReadLine().ToUpper();

                            // prompt for assigned
                            Console.WriteLine("Enter who is assigned to the ticket:  ");

                            // save the assigned
                            string assigned = Console.ReadLine().ToUpper();

                            // prompt for watching
                            Console.WriteLine("Enter who is watching the ticket: ");

                            // save the watching
                            string watching = Console.ReadLine().ToUpper();


                            sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", ticketid, summary, status, priority, submitter, assigned, watching);
                        }
                        sw.Close();
                    }
                } while (choice == "1" || choice == "2") ;
            }
        }
    }
}
    
