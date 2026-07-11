using ITPCA_Q1_CODE;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LATEST SERIES - 2025");
        Console.WriteLine("********************************");
        Console.WriteLine("Enter (1) to launch menu or any other key to exit ");
        string choice = (Console.ReadLine());
        string selection;

        Series series = new Series();


        if (choice == "1")
        {
            do
            {

                Console.WriteLine("(1) Capture a new series.");
                Console.WriteLine("(2) Search for a series.");
                Console.WriteLine("(3) Update series age restriction.");
                Console.WriteLine("(4) Delete a series.");
                Console.WriteLine("(5) Print series report - 2025");
                Console.WriteLine("(6) Exit application");
                selection = Console.ReadLine();

                if (selection == "1")
                {

                    series.CaptureSeries();
                }
                else if (selection == "2")
                {
                    series.SearchSeries();
                }
                else if (selection == "3")
                {
                    series.UpdateSeries();
                }
                else if (selection == "4")
                {
                    series.DeleteSeries();
                }
                else if (selection == "5")
                {
                    series.SeriesReport();
                }
                else if (selection == "6")
                {
                    series.ExitSeriesApplication();
                }
                else
                {
                    Console.WriteLine("Invalid menu option selected. Please choose a valid option from the menu.");
                }

                Console.WriteLine("Enter (1) to launch menu or any other number to exit ");
                choice = (Console.ReadLine());

            } while (choice == "1");
        }
        else
        {
            Console.WriteLine("Apllication has been ended");
        }
    }
}
