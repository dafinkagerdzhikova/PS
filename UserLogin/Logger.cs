using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
        static public class Logger
        {
            private static List<string> currentSessionActivities = new List<string>();

            public static void LogActivity(string activity)
            {
                string activityLine = DateTime.Now + ";" + LoginValidation.currentUserName + ";" +
                                      LoginValidation.currentUserRole + ";" + activity;

                if (File.Exists("test.txt") == true)
                {
                    File.AppendAllText("test.txt", activityLine);
                }

            currentSessionActivities.Add(activityLine);
        }


        static public IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            List<string> filteredActivities = (from activity in currentSessionActivities
                                               where activity.Contains(filter)
                                               select activity).ToList();
            return filteredActivities;
        }
        static public void LogError(string errorMessage)
        {
            string errorMessageLine = "ERROR "
                + DateTime.Now + " "
                + LoginValidation.currentUserName + " "
                + LoginValidation.currentUserRole + " "
                + errorMessage;
            currentSessionActivities.Add(errorMessage);
            WriteLogInFile(errorMessage);
            Console.WriteLine(errorMessage);
        }

        static private void WriteLogInFile(string activity)
        {
            if (File.Exists("test.txt") == true)
            {
                File.AppendAllText("test.txt", activity + "\n");
            }
        }

        static public void ShowLogFile()
        {
            if (File.Exists("test.txt") == true)
            {
                StreamReader outputFile = new StreamReader("test.txt");
                string line = null;
                do
                {
                    line = outputFile.ReadLine();
                    Console.WriteLine(line);
                } while (line != null);
                outputFile.Close();
            }
        }
    }
}