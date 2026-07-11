using System;
using System.Collections.Generic;
using System.Text;

namespace ITPCA_Q1_CODE
{
    public class Series
    {
        List<SeriesModel> seriesList = new List<SeriesModel>();

        public void CaptureSeries()
        {

            SeriesModel series = new SeriesModel();

            Console.WriteLine("CAPTURE A NEW SERIES");
            Console.WriteLine("********************************");
            Console.WriteLine("Enter the series ID: ");
            series.SeriesId = Console.ReadLine();

            while (series.SeriesId == "")
            {

                Console.WriteLine("Series ID cannot be empty. Please try again.");
                Console.WriteLine("Enter the series ID: ");
                series.SeriesId = Console.ReadLine();

            } 


            Console.WriteLine("Enter the series name: ");
            series.SeriesName = Console.ReadLine();

            while (series.SeriesName == "") 
            {
                Console.WriteLine("Series name cannot be empty. Please try again.");
                Console.WriteLine("Enter the series name: ");
                series.SeriesName = Console.ReadLine();
            }

            try
            {
                Console.WriteLine("Enter the series age restriction: ");
                series.SeriesAge = int.Parse(Console.ReadLine());

                if (series.SeriesAge < 2 | series.SeriesAge > 18)
                {

                    do
                    {
                        Console.WriteLine("You have entered an incorrect series age!!! ");
                        Console.WriteLine("Please re-enter the series age ");

                        series.SeriesAge = int.Parse(Console.ReadLine());
                    } while (series.SeriesAge < 2 | series.SeriesAge > 18);
                }

                Console.WriteLine("Enter the number of episodes: ");
                series.SeriesNumberOfEpisodes = int.Parse(Console.ReadLine());

                seriesList.Add(series);

                Console.WriteLine("Series processed successfully!!! ");
                Console.WriteLine(" ");
            }
            catch(FormatException e)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Please enter a numeric value.");
                Console.WriteLine("----------------------------------");
            }

        }

        public void SearchSeries()
        {
            Console.WriteLine("Enter the series ID to search: ");
            string Id = Console.ReadLine();

            while (Id == "")
            {
                Console.WriteLine("Series ID cannot be empty. Please try again.");
                Console.WriteLine("Enter the series ID to search: ");
                Id = Console.ReadLine();
            }

            bool found = false;

            Console.WriteLine("----------------------------------");

            foreach (SeriesModel series in seriesList)
            {
                if (series.SeriesId == Id)
                {
                    Console.WriteLine("SERIES ID: " + series.SeriesId);
                    Console.WriteLine("SERIES NAME: " + series.SeriesName);
                    Console.WriteLine("SERIES AGE RESTRICTION: " + series.SeriesAge);
                    Console.WriteLine("SERIES NUMBER OF EPISODES: " + series.SeriesNumberOfEpisodes);
                    Console.WriteLine("----------------------------------");

                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Series with ID " + Id + " was not found!");
                Console.WriteLine("----------------------------------");
            }

        }

        public void UpdateSeries()
        {
            try
            {
                bool found = false;
                Console.WriteLine("Enter the series ID to update: ");
                string Id = Console.ReadLine();


                while (Id == "")
                {
                    Console.WriteLine("Series ID cannot be empty. Please try again.");
                    Console.WriteLine("Enter the series ID to update: ");
                    Id = Console.ReadLine();
                }

                Console.WriteLine("----------------------------------");

                foreach (SeriesModel series in seriesList)
                {
                    if (series.SeriesId == Id)
                    {
                        Console.WriteLine("Enter the series name: ");
                        series.SeriesName = Console.ReadLine();

                        while (series.SeriesName == "")
                        {
                            Console.WriteLine("Series name cannot be empty. Please try again.");
                            Console.WriteLine("Enter the series name: ");
                            series.SeriesName = Console.ReadLine();
                        }

                        Console.WriteLine("Enter the series age restriction: ");
                        series.SeriesAge = int.Parse(Console.ReadLine());

                        if (series.SeriesAge < 2 | series.SeriesAge > 18)
                        {

                            do
                            {
                                Console.WriteLine("You have entered an incorrect series age!!! ");
                                Console.WriteLine("Please re-enter the series age ");

                                series.SeriesAge = int.Parse(Console.ReadLine());
                            } while (series.SeriesAge < 2 | series.SeriesAge > 18);
                        }

                        Console.WriteLine("Enter the number of episodes: ");
                        series.SeriesNumberOfEpisodes = int.Parse(Console.ReadLine());

                        found = true;

                    }
                }
                if (!found)
                {
                    Console.WriteLine("Series with ID " + Id + " was not found!");
                    Console.WriteLine("----------------------------------");
                }
            } 
            catch(FormatException e)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Please enter a numeric value.");
                Console.WriteLine("----------------------------------");
            }
        }

        public void DeleteSeries()
        {

            bool found = false;
            SeriesModel series = new SeriesModel();
            Console.WriteLine("Enter the series ID to delete: ");
            string Id = Console.ReadLine();

            while (Id == "")
            {
                Console.WriteLine("Series ID cannot be empty. Please try again.");
                Console.WriteLine("Enter the series ID to delete: ");
                Id = Console.ReadLine();
            }

            Console.WriteLine("----------------------------------");

            for (int i = 0; i < seriesList.Count; i++)
            {
                if (seriesList[i].SeriesId == Id)
                {
                    Console.WriteLine("Are you sure you want to delete " + seriesList[i].SeriesId + " from the system? Yes(y) or No(n)");
                    string choice = Console.ReadLine();

                    if (choice == "y" || choice == "Y")
                    {
                        seriesList.RemoveAt(i);
                        Console.WriteLine("Series with series ID: " + seriesList[i].SeriesId + " was deleted");
                    }
                    else if (choice == "n" || choice == "N")
                    {
                        Console.WriteLine("Series with series ID: " + seriesList[i].SeriesId + " was not deleted");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                    found = true;
                }
                
            }
            if (!found)
            {

                Console.WriteLine("Series with ID " + Id + " was not found!");
                Console.WriteLine("----------------------------------");
            }

        }

        public void SeriesReport()
        {
            int count = 1;
            foreach (SeriesModel series in seriesList)
            {
                Console.WriteLine("SERIES " + count);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("SERIES ID: " + series.SeriesId);
                Console.WriteLine("SERIES NAME: " + series.SeriesName);
                Console.WriteLine("SERIES AGE RESTRICTION: " + series.SeriesAge);
                Console.WriteLine("SERIES NUMBER OF EPISODES: " + series.SeriesNumberOfEpisodes);
                Console.WriteLine("----------------------------------");
                count++;

            }
        }

        public void ExitSeriesApplication()
        {
            Console.WriteLine("Exited series application");
        }
    }


}
